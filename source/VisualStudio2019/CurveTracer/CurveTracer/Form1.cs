using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;

namespace CurveTracer
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> COMMPorts;
        public Form1()
        {
            InitializeComponent();

            SetCOMMPorts();

            serialPort1.NewLine = "\r\n";
        }
        private void SetCOMMPorts()
        {
            COMMPorts = EnumSerialPort.DeviceNames;

            cmbPortSelect.DataSource = new BindingSource(COMMPorts, null);
            cmbPortSelect.DisplayMember = "Value";
            cmbPortSelect.ValueMember = "Key";
        }
        private CancellationTokenSource m_CancelToken;

        private async void btnStartMeasureCurve_Click(object sender, EventArgs e)
        {
            if (chkCurveRunning.Checked == false)
            {
                Loop lPlate, lGrid;
                double G2 = 0;
                bool SetG2 = rdoTubeSelectPentode.Checked;

                try
                {
                    lPlate = new Loop(
                        start: double.Parse(txtPlateVoltageInitial.Text),
                        end: double.Parse(txtPlateVoltageLast.Text),
                        step: double.Parse(txtPlateVoltageStep.Text));
                    lGrid = new Loop(
                        start: double.Parse(txtGridVoltageInitial.Text),
                        end: double.Parse(txtGridVoltageLast.Text),
                        step: double.Parse(txtGridVoltageStep.Text));

                    G2 = SetG2 ? double.Parse(txtGrid2VoltageCurve.Text) : 0;

                    if(lPlate.Start > lPlate.End)
                    {
                        MessageBox.Show("開始値は終了値より小さくなければなりません");
                        return;
                    }
                    if(lPlate.Step <= 0)
                    {
                        MessageBox.Show("ステップ値は正の値でなければなりません");
                        return;
                    }
                    if (lGrid.Start > lGrid.End)
                    {
                        MessageBox.Show("開始値は終了値より小さくなければなりません");
                        return;
                    }
                    if (lGrid.Step <= 0)
                    {
                        MessageBox.Show("ステップ値は正の値でなければなりません");
                        return;
                    }

                    if(lPlate.Start < 0 || lPlate.End > 20)
                    {
                        MessageBox.Show("プレート電圧は0V～20Vの範囲で指定してください");
                        return;
                    }
                    if(lGrid.Start < -1 || lGrid.End > 1)
                    {
                        MessageBox.Show("グリッド電圧は-1V～1Vの範囲で指定してください");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                if (serialPort1.IsOpen) serialPort1.Close();
                serialPort1.PortName = cmbPortSelect.SelectedValue as string;
                serialPort1.Open();

                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();

                chartCurveResult.Series.Clear();
                lvCurveResult.Items.Clear();
                chartCurveResult.ChartAreas[0].AxisX.Maximum = lPlate.End;
                chartCurveResult.ChartAreas[0].AxisY.Maximum = double.NaN;
                chartCurveResult.Titles.Clear();
                chartCurveResult.Titles.Add(txtGraphTitle.Text);
                chkCurveRunning.Checked = true;
                m_CancelToken = new CancellationTokenSource();
                btnStartMeasureCurve.Text = "中断";
                await Task.Run(() => {
                    MeasureCurve(lGrid, lPlate, G2); 
                });
                btnStartMeasureCurve.Text = "測定開始";
                chkCurveRunning.Checked = false;
                serialPort1.Close();

            }
            else
            {
                m_CancelToken.Cancel();
            }
        }

        class Loop
        {
            public Loop(double start, double end, double step)
            {
                Start = start;
                End = end;
                Step = step;
            }
            public double Start { get; private set; }
            public double End { get; private set; }
            public double Step { get; private set; }
        }

        private void MeasureCurve(Loop lGrid, Loop lPlate, double G2)
        {
            string r;
            r = SerialSend($"S2{G2:0.00}", true);

            for (double grid = lGrid.Start; grid <= lGrid.End; grid += lGrid.Step)
            {
                if (m_CancelToken.IsCancellationRequested) break;
                var g = new ListViewGroup();
                var s = new System.Windows.Forms.DataVisualization.Charting.Series();
                r = SerialSend($"S3{grid:0.0}", true);

                this.Invoke(new MethodInvoker(() =>
                {
                    s = chartCurveResult.Series.Add($"Grid={grid:0.00}V");
                    g = new ListViewGroup($"Grid={grid:0.00}V");
                    lvCurveResult.Groups.Add(g);
                    s.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                }));
                for (var plate = lPlate.Start; plate <= lPlate.End; plate += lPlate.Step)
                {
                    if (m_CancelToken.IsCancellationRequested) break;
                    r = SerialSend($"S1{plate:0.0}", true);
                    string PV = SerialSend("G1", true);
                    string PI = SerialSend("G4", true);
                    double pi = double.Parse(PI);
                    double pv = double.Parse(PV);

                    this.Invoke(new MethodInvoker(() => {
                        s.Points.AddXY(pv, pi);
                        var itm = lvCurveResult.Items.Add($"{pv:0.0}");
                        itm.SubItems.Add($"{pi:0.000}");
                        itm.Group = g;
                        lvCurveResult.EnsureVisible(lvCurveResult.Items.Count - 1);
                    }));
                }
            }
        }

        private void rdoTubeSelect_CheckChanbed(object sender, EventArgs e)
        {
            txtG2VoltageSet.Enabled = rdoTubeSelectPentode.Checked;
            txtG2VoltageRead.Enabled = rdoTubeSelectPentode.Checked;
            txtGrid2VoltageCurve.Enabled = rdoTubeSelectPentode.Checked;
            if(rdoTubeSelectTriode.Checked) txtG2VoltageRead.Clear();
        }

        private async void btnSetDA_Click(object sender, EventArgs e)
        {
            bool SetG2 = rdoTubeSelectPentode.Checked;

            double G2, G1, P;

            try
            {
                G2 = string.IsNullOrEmpty(txtG2VoltageSet.Text) ? 0 : double.Parse(txtG2VoltageSet.Text);
                G1 = string.IsNullOrEmpty(txtG1VoltageSet.Text) ? 0 : double.Parse(txtG1VoltageSet.Text);
                P = string.IsNullOrEmpty(txtPlateVoltageSet.Text) ? 0 : double.Parse(txtPlateVoltageSet.Text);

                if (serialPort1.IsOpen) serialPort1.Close();

                serialPort1.PortName = cmbPortSelect.SelectedValue as string;
                serialPort1.NewLine = "\r\n";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            await Task.Run(() => {
                string r;
                try
                {
                    serialPort1.Open();

                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();

                    r = SerialSend($"S1{P:0.00}", true);
                    if (SetG2)
                    {
                        r = SerialSend($"S2{G2:0.00}", true);
                    }
                    r = SerialSend($"S3{G1:0.00}", true);

                    serialPort1.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (serialPort1.IsOpen) serialPort1.Close();
                    return;
                }
            });


            MessageBox.Show("セットしました");
        }

        private string SerialSend(string s, bool read = false)
        {
            string r = string.Empty;
            serialPort1.WriteLine(s);
            if (frm != null && frm.IsDisposed == false) SetLog($"TX:{s}");
            if (read)
            {
                r = serialPort1.ReadLine();
                if (frm != null && frm.IsDisposed == false) SetLog($"RX:{r}");
            }

            return r;
        }

        private void btnSetCommPorts_Click(object sender, EventArgs e)
        {
            SetCOMMPorts();
        }

        frmLog frm = null;

        private void SetLog(string s)
        {
            if (frm is null) return;
            if (frm.IsDisposed) return;

            if(InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => {
                    frm.SetLog(s);
                }));
            }
            else
            {
                frm.SetLog(s);
            }
        }

        private void btnOpenLogWindow_Click(object sender, EventArgs e)
        {
            if (frm is null) frm = new frmLog();
            if (frm.IsDisposed) frm = new frmLog();

            frm.Show();
        }

        private async void btnMeasure_Click(object sender, EventArgs e)
        {
            bool SetG2 = rdoTubeSelectPentode.Checked;

            try
            {
                if (serialPort1.IsOpen) serialPort1.Close();

                serialPort1.PortName = cmbPortSelect.SelectedValue as string;
                serialPort1.NewLine = "\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            await Task.Run(() => {
            string r;

            string PV, G2V, G1V, PI, HV, HI;

            try
            {
                serialPort1.Open();

                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();

                PV = SerialSend("G1", true);
                if (SetG2)
                {
                    G2V = SerialSend("G2", true);
                }
                else
                {
                    G2V = string.Empty;
                }
                G1V = SerialSend("G3", true);
                PI = SerialSend("G4", true);
                HV = SerialSend("G5", true);
                HI = SerialSend("G6", true);

                this.Invoke(new MethodInvoker(() => 
                {
                    txtPlateVoltageRead.Text = PV;
                    txtG2VoltageRead.Text = G2V;
                    txtG1VoltageRead.Text = G1V;
                    txtPlateCurrentRead.Text = PI;
                    txtHeaterVoltageRead.Text = HV;
                    txtHeaterCurrentRead.Text = HI;
                }));

                serialPort1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (serialPort1.IsOpen) serialPort1.Close();
                }
            });
        }

        System.Windows.Forms.DataVisualization.Charting.Series seriesLoadLine = null;

        private void btnShowLoadLine_Click(object sender, EventArgs e)
        {
            double V, R, I;

            try
            {
                V = double.Parse(txtLoadLineVoltage.Text);
                R = double.Parse(txtLoadLineResister.Text);
                if (R <= 0) throw new ArgumentOutOfRangeException("抵抗値を0以下にすることはできません");
                if (V < 0) throw new ArgumentOutOfRangeException("電圧をマイナスの値にすることはできません");
                I = V / R;
            }
            catch(Exception ex)
            {
                MessageBox.Show("入力値が不正です:\n" + ex.Message);
                return;
            }

            if (seriesLoadLine is null)
            {
                seriesLoadLine = chartCurveResult.Series.Add($"{txtLoadLineVoltage.Text}V {txtLoadLineResister.Text}kΩ");
            }
            else
            {
                seriesLoadLine.Points.Clear();
            }

            var maxY = chartCurveResult.ChartAreas[0].AxisY.Maximum;
            var maxX = chartCurveResult.ChartAreas[0].AxisX.Maximum;

            seriesLoadLine.Points.AddXY(0, I);
            seriesLoadLine.Points.AddXY(V, 0);
            seriesLoadLine.ChartType = SeriesChartType.Line;

            chartCurveResult.ChartAreas[0].AxisX.Maximum = maxX;
            chartCurveResult.ChartAreas[0].AxisY.Maximum = maxY;

        }

        private void btnHideLoadLine_Click(object sender, EventArgs e)
        {
            if (seriesLoadLine is null)
            {
            }
            else
            {
                chartCurveResult.Series.Remove(seriesLoadLine);
                seriesLoadLine = null;
            }
        }

        private void btnSaveGraphImage_Click(object sender, EventArgs e)
        {
            using (var frm = new SaveFileDialog())
            {
                frm.Filter = "PNG|*.png|BMP|*.bmp|JPEG|*.jpg|EMF|*.emf";
                var r = frm.ShowDialog();
                if (r != DialogResult.OK) return;
                var ext = Path.GetExtension(frm.FileName).ToLower();
                try
                {
                    switch (ext)
                    {
                        case ".png":
                            chartCurveResult.SaveImage(frm.FileName, ChartImageFormat.Png);
                            break;
                        case ".bmp":
                            chartCurveResult.SaveImage(frm.FileName, ChartImageFormat.Bmp);
                            break;
                        case ".jpg":
                            chartCurveResult.SaveImage(frm.FileName, ChartImageFormat.Jpeg);
                            break;
                        case ".emf":
                            chartCurveResult.SaveImage(frm.FileName, ChartImageFormat.EmfDual);
                            break;
                        default:
                            chartCurveResult.SaveImage(frm.FileName, ChartImageFormat.Png);
                            break;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("保存に失敗しました\n" + ex.Message);
                }
            }
        }

        private void btnSaveCSV_Click(object sender, EventArgs e)
        {
            using (var frm = new SaveFileDialog())
            {
                frm.Filter = "CSV|*.csv";
                var r = frm.ShowDialog();
                if (r != DialogResult.OK) return;

                var maxY = chartCurveResult.ChartAreas[0].AxisY.Maximum;
                var maxX = chartCurveResult.ChartAreas[0].AxisX.Maximum;

                //using (var sw = new System.IO.StringWriter())
                try
                {
                    using (var sw = new StreamWriter(frm.FileName, false, Encoding.UTF8))
                    {
                        sw.WriteLine($"CurveTracer,{txtGraphTitle.Text.Replace(",", "_")},{maxX:0}|{maxY:0.0}");
                        sw.WriteLine("Grid(V),Plate(V),Plate(mA)");
                        foreach (ListViewItem itm in lvCurveResult.Items)
                        {
                            string g = Regex.Match(itm.Group.Header, @"-?\d\.\d{2}").Value;
                            sw.WriteLine($"{g},{itm.Text},{itm.SubItems[1].Text}");
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("保存に失敗しました:\n" + ex.Message);
                }
            }
        }

        private void btnSetTitle_Click(object sender, EventArgs e)
        {
            chartCurveResult.Titles.Clear();
            chartCurveResult.Titles.Add(txtGraphTitle.Text);
        }

        private void btnReadCSV_Click(object sender, EventArgs e)
        {
            using (var frm = new OpenFileDialog())
            {
                frm.Filter = "CSV|*.csv";
                var r = frm.ShowDialog();
                if (r != DialogResult.OK) return;
                try
                {
                    using (var sr = new StreamReader(frm.FileName))
                    {
                        string line = sr.ReadLine();
                        string[] col = line.Split(',');
                        string[] max = col[2].Split('|');
                        if (col.Length != 3 || col[0] != "CurveTracer" || max.Length != 2)
                        {
                            MessageBox.Show("ファイルが不正です");
                            return;
                        }
                        double maxX, maxY;
                        //txtGraphTitle.Text = col[1];
                        try
                        {
                            maxX = double.Parse(max[0]);
                            maxY = double.Parse(max[1]);
                        }
                        catch
                        {
                            MessageBox.Show("ファイルが不正です");
                            return;
                        }

                        chartCurveResult.Series.Clear();
                        lvCurveResult.Items.Clear();
                        chartCurveResult.ChartAreas[0].AxisX.Maximum = maxX;// lPlate.End;
                        chartCurveResult.ChartAreas[0].AxisY.Maximum = double.NaN;
                        chartCurveResult.Titles.Clear();
                        chartCurveResult.Titles.Add(col[1].Trim());

                        line = sr.ReadLine(); //カラムタイトルなので読み飛ばし

                        double grid, pi, pv;
                        string G, PI, PV;

                        Dictionary<string, (ListViewGroup g, Series s)> dictG = new Dictionary<string, (ListViewGroup, Series)>();

                        ListViewGroup g;
                        Series s = new Series();

                        while ((line = sr.ReadLine()) != null)
                        {
                            col = line.Split(',');

                            if (col.Length != 3) continue;
                            try
                            {
                                G = col[0].Trim();
                                PV = col[1].Trim();
                                PI = col[2].Trim();

                                grid = double.Parse(G);
                                pv = double.Parse(PV);
                                pi = double.Parse(PI);

                                if (dictG.ContainsKey(G) == false)
                                {
                                    s = chartCurveResult.Series.Add($"Grid={grid:0.00}V");
                                    g = new ListViewGroup($"Grid={grid:0.00}V");

                                    dictG.Add(G, (g, s));
                                    lvCurveResult.Groups.Add(g);
                                    s.ChartType = SeriesChartType.Line;
                                }
                                else
                                {
                                    (g, s) = dictG[G];
                                }
                                s.Points.AddXY(pv, pi);
                                var itm = lvCurveResult.Items.Add($"{pv:0.0}");
                                itm.SubItems.Add($"{pi:0.000}");
                                itm.Group = g;
                                lvCurveResult.EnsureVisible(lvCurveResult.Items.Count - 1);
                            }
                            catch
                            {
                                continue;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("読み込みに失敗しました:\n" + ex.Message);
                }
            }
        }
    }
}
