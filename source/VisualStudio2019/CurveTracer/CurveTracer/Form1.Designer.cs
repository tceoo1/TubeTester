
namespace CurveTracer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rdoTubeSelectTriode = new System.Windows.Forms.RadioButton();
            this.rdoTubeSelectPentode = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnMeasure = new System.Windows.Forms.Button();
            this.txtPlateCurrentRead = new System.Windows.Forms.TextBox();
            this.txtPlateVoltageRead = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtG1VoltageRead = new System.Windows.Forms.TextBox();
            this.txtG2VoltageRead = new System.Windows.Forms.TextBox();
            this.txtHeaterCurrentRead = new System.Windows.Forms.TextBox();
            this.txtHeaterVoltageRead = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtG2VoltageSet = new System.Windows.Forms.TextBox();
            this.txtG1VoltageSet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPlateVoltageSet = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSetDA = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkCurveRunning = new System.Windows.Forms.CheckBox();
            this.btnStartMeasureCurve = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGridVoltageStep = new System.Windows.Forms.TextBox();
            this.txtPlateVoltageStep = new System.Windows.Forms.TextBox();
            this.txtGridVoltageLast = new System.Windows.Forms.TextBox();
            this.txtPlateVoltageLast = new System.Windows.Forms.TextBox();
            this.txtGrid2VoltageCurve = new System.Windows.Forms.TextBox();
            this.txtGridVoltageInitial = new System.Windows.Forms.TextBox();
            this.txtPlateVoltageInitial = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chartCurveResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lvCurveResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbPortSelect = new System.Windows.Forms.ComboBox();
            this.btnSetCommPort = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnOpenLogWindow = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtLoadLineVoltage = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtLoadLineResister = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.btnHideLoadLine = new System.Windows.Forms.Button();
            this.btnShowLoadLine = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCurveResult)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoTubeSelectTriode
            // 
            this.rdoTubeSelectTriode.AutoSize = true;
            this.rdoTubeSelectTriode.Location = new System.Drawing.Point(6, 18);
            this.rdoTubeSelectTriode.Name = "rdoTubeSelectTriode";
            this.rdoTubeSelectTriode.Size = new System.Drawing.Size(124, 16);
            this.rdoTubeSelectTriode.TabIndex = 0;
            this.rdoTubeSelectTriode.TabStop = true;
            this.rdoTubeSelectTriode.Text = "三極管(G2制御なし)";
            this.rdoTubeSelectTriode.UseVisualStyleBackColor = true;
            this.rdoTubeSelectTriode.CheckedChanged += new System.EventHandler(this.rdoTubeSelect_CheckChanbed);
            // 
            // rdoTubeSelectPentode
            // 
            this.rdoTubeSelectPentode.AutoSize = true;
            this.rdoTubeSelectPentode.Location = new System.Drawing.Point(6, 40);
            this.rdoTubeSelectPentode.Name = "rdoTubeSelectPentode";
            this.rdoTubeSelectPentode.Size = new System.Drawing.Size(59, 16);
            this.rdoTubeSelectPentode.TabIndex = 1;
            this.rdoTubeSelectPentode.TabStop = true;
            this.rdoTubeSelectPentode.Text = "五極管";
            this.rdoTubeSelectPentode.UseVisualStyleBackColor = true;
            this.rdoTubeSelectPentode.CheckedChanged += new System.EventHandler(this.rdoTubeSelect_CheckChanbed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTubeSelectPentode);
            this.groupBox1.Controls.Add(this.rdoTubeSelectTriode);
            this.groupBox1.Location = new System.Drawing.Point(560, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "管種類選択";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.btnMeasure);
            this.groupBox2.Controls.Add(this.txtPlateCurrentRead);
            this.groupBox2.Controls.Add(this.txtPlateVoltageRead);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtG1VoltageRead);
            this.groupBox2.Controls.Add(this.txtG2VoltageRead);
            this.groupBox2.Controls.Add(this.txtHeaterCurrentRead);
            this.groupBox2.Controls.Add(this.txtHeaterVoltageRead);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(349, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 182);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "計測値";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(198, 146);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(22, 12);
            this.label24.TabIndex = 5;
            this.label24.Text = "mA";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(198, 121);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 12);
            this.label23.TabIndex = 5;
            this.label23.Text = "V";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(198, 96);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 12);
            this.label22.TabIndex = 5;
            this.label22.Text = "V";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(198, 71);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 12);
            this.label21.TabIndex = 5;
            this.label21.Text = "V";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(198, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 12);
            this.label20.TabIndex = 5;
            this.label20.Text = "mA";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(198, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 12);
            this.label19.TabIndex = 5;
            this.label19.Text = "V";
            // 
            // btnMeasure
            // 
            this.btnMeasure.Location = new System.Drawing.Point(226, 136);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(57, 33);
            this.btnMeasure.TabIndex = 0;
            this.btnMeasure.Text = "計測";
            this.btnMeasure.UseVisualStyleBackColor = true;
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // txtPlateCurrentRead
            // 
            this.txtPlateCurrentRead.Location = new System.Drawing.Point(89, 143);
            this.txtPlateCurrentRead.Name = "txtPlateCurrentRead";
            this.txtPlateCurrentRead.ReadOnly = true;
            this.txtPlateCurrentRead.Size = new System.Drawing.Size(103, 19);
            this.txtPlateCurrentRead.TabIndex = 1;
            // 
            // txtPlateVoltageRead
            // 
            this.txtPlateVoltageRead.Location = new System.Drawing.Point(89, 118);
            this.txtPlateVoltageRead.Name = "txtPlateVoltageRead";
            this.txtPlateVoltageRead.ReadOnly = true;
            this.txtPlateVoltageRead.Size = new System.Drawing.Size(103, 19);
            this.txtPlateVoltageRead.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "プレート電圧";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ヒータ電圧";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "G1電圧";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ヒータ電流";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "G2電圧";
            // 
            // txtG1VoltageRead
            // 
            this.txtG1VoltageRead.Location = new System.Drawing.Point(89, 93);
            this.txtG1VoltageRead.Name = "txtG1VoltageRead";
            this.txtG1VoltageRead.ReadOnly = true;
            this.txtG1VoltageRead.Size = new System.Drawing.Size(103, 19);
            this.txtG1VoltageRead.TabIndex = 1;
            // 
            // txtG2VoltageRead
            // 
            this.txtG2VoltageRead.Location = new System.Drawing.Point(89, 68);
            this.txtG2VoltageRead.Name = "txtG2VoltageRead";
            this.txtG2VoltageRead.ReadOnly = true;
            this.txtG2VoltageRead.Size = new System.Drawing.Size(103, 19);
            this.txtG2VoltageRead.TabIndex = 1;
            // 
            // txtHeaterCurrentRead
            // 
            this.txtHeaterCurrentRead.Location = new System.Drawing.Point(89, 43);
            this.txtHeaterCurrentRead.Name = "txtHeaterCurrentRead";
            this.txtHeaterCurrentRead.ReadOnly = true;
            this.txtHeaterCurrentRead.Size = new System.Drawing.Size(103, 19);
            this.txtHeaterCurrentRead.TabIndex = 1;
            // 
            // txtHeaterVoltageRead
            // 
            this.txtHeaterVoltageRead.Location = new System.Drawing.Point(89, 18);
            this.txtHeaterVoltageRead.Name = "txtHeaterVoltageRead";
            this.txtHeaterVoltageRead.ReadOnly = true;
            this.txtHeaterVoltageRead.Size = new System.Drawing.Size(103, 19);
            this.txtHeaterVoltageRead.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "プレート電流";
            // 
            // txtG2VoltageSet
            // 
            this.txtG2VoltageSet.Location = new System.Drawing.Point(85, 18);
            this.txtG2VoltageSet.Name = "txtG2VoltageSet";
            this.txtG2VoltageSet.Size = new System.Drawing.Size(103, 19);
            this.txtG2VoltageSet.TabIndex = 0;
            // 
            // txtG1VoltageSet
            // 
            this.txtG1VoltageSet.Location = new System.Drawing.Point(85, 43);
            this.txtG1VoltageSet.Name = "txtG1VoltageSet";
            this.txtG1VoltageSet.Size = new System.Drawing.Size(103, 19);
            this.txtG1VoltageSet.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "G2電圧";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "G1電圧";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "プレート電圧";
            // 
            // txtPlateVoltageSet
            // 
            this.txtPlateVoltageSet.Location = new System.Drawing.Point(85, 68);
            this.txtPlateVoltageSet.Name = "txtPlateVoltageSet";
            this.txtPlateVoltageSet.Size = new System.Drawing.Size(103, 19);
            this.txtPlateVoltageSet.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSetDA);
            this.groupBox3.Controls.Add(this.txtPlateVoltageSet);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtG2VoltageSet);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.txtG1VoltageSet);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(26, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 101);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "電圧設定";
            // 
            // btnSetDA
            // 
            this.btnSetDA.Location = new System.Drawing.Point(238, 54);
            this.btnSetDA.Name = "btnSetDA";
            this.btnSetDA.Size = new System.Drawing.Size(57, 33);
            this.btnSetDA.TabIndex = 3;
            this.btnSetDA.Text = "設定";
            this.btnSetDA.UseVisualStyleBackColor = true;
            this.btnSetDA.Click += new System.EventHandler(this.btnSetDA_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(194, 71);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(13, 12);
            this.label27.TabIndex = 5;
            this.label27.Text = "V";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(194, 46);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(13, 12);
            this.label26.TabIndex = 5;
            this.label26.Text = "V";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(194, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(13, 12);
            this.label25.TabIndex = 5;
            this.label25.Text = "V";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkCurveRunning);
            this.groupBox4.Controls.Add(this.btnStartMeasureCurve);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtGridVoltageStep);
            this.groupBox4.Controls.Add(this.txtPlateVoltageStep);
            this.groupBox4.Controls.Add(this.txtGridVoltageLast);
            this.groupBox4.Controls.Add(this.txtPlateVoltageLast);
            this.groupBox4.Controls.Add(this.txtGrid2VoltageCurve);
            this.groupBox4.Controls.Add(this.txtGridVoltageInitial);
            this.groupBox4.Controls.Add(this.txtPlateVoltageInitial);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(475, 146);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "計測条件";
            // 
            // chkCurveRunning
            // 
            this.chkCurveRunning.AutoCheck = false;
            this.chkCurveRunning.AutoSize = true;
            this.chkCurveRunning.Location = new System.Drawing.Point(369, 14);
            this.chkCurveRunning.Name = "chkCurveRunning";
            this.chkCurveRunning.Size = new System.Drawing.Size(60, 16);
            this.chkCurveRunning.TabIndex = 4;
            this.chkCurveRunning.Text = "実行中";
            this.chkCurveRunning.UseVisualStyleBackColor = true;
            // 
            // btnStartMeasureCurve
            // 
            this.btnStartMeasureCurve.Location = new System.Drawing.Point(374, 41);
            this.btnStartMeasureCurve.Name = "btnStartMeasureCurve";
            this.btnStartMeasureCurve.Size = new System.Drawing.Size(75, 95);
            this.btnStartMeasureCurve.TabIndex = 7;
            this.btnStartMeasureCurve.Text = "計測開始";
            this.btnStartMeasureCurve.UseVisualStyleBackColor = true;
            this.btnStartMeasureCurve.Click += new System.EventHandler(this.btnStartMeasureCurve_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(247, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "ステップ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "ステップ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(130, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "終了値";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(130, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "終了値";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "初期値";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "初期値";
            // 
            // txtGridVoltageStep
            // 
            this.txtGridVoltageStep.Location = new System.Drawing.Point(292, 81);
            this.txtGridVoltageStep.Name = "txtGridVoltageStep";
            this.txtGridVoltageStep.Size = new System.Drawing.Size(64, 19);
            this.txtGridVoltageStep.TabIndex = 5;
            // 
            // txtPlateVoltageStep
            // 
            this.txtPlateVoltageStep.Location = new System.Drawing.Point(292, 41);
            this.txtPlateVoltageStep.Name = "txtPlateVoltageStep";
            this.txtPlateVoltageStep.Size = new System.Drawing.Size(64, 19);
            this.txtPlateVoltageStep.TabIndex = 2;
            // 
            // txtGridVoltageLast
            // 
            this.txtGridVoltageLast.Location = new System.Drawing.Point(177, 81);
            this.txtGridVoltageLast.Name = "txtGridVoltageLast";
            this.txtGridVoltageLast.Size = new System.Drawing.Size(64, 19);
            this.txtGridVoltageLast.TabIndex = 4;
            // 
            // txtPlateVoltageLast
            // 
            this.txtPlateVoltageLast.Location = new System.Drawing.Point(177, 41);
            this.txtPlateVoltageLast.Name = "txtPlateVoltageLast";
            this.txtPlateVoltageLast.Size = new System.Drawing.Size(64, 19);
            this.txtPlateVoltageLast.TabIndex = 1;
            // 
            // txtGrid2VoltageCurve
            // 
            this.txtGrid2VoltageCurve.Location = new System.Drawing.Point(128, 121);
            this.txtGrid2VoltageCurve.Name = "txtGrid2VoltageCurve";
            this.txtGrid2VoltageCurve.Size = new System.Drawing.Size(64, 19);
            this.txtGrid2VoltageCurve.TabIndex = 6;
            // 
            // txtGridVoltageInitial
            // 
            this.txtGridVoltageInitial.Location = new System.Drawing.Point(60, 81);
            this.txtGridVoltageInitial.Name = "txtGridVoltageInitial";
            this.txtGridVoltageInitial.Size = new System.Drawing.Size(64, 19);
            this.txtGridVoltageInitial.TabIndex = 3;
            // 
            // txtPlateVoltageInitial
            // 
            this.txtPlateVoltageInitial.Location = new System.Drawing.Point(60, 41);
            this.txtPlateVoltageInitial.Name = "txtPlateVoltageInitial";
            this.txtPlateVoltageInitial.Size = new System.Drawing.Size(64, 19);
            this.txtPlateVoltageInitial.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 124);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(113, 12);
            this.label28.TabIndex = 0;
            this.label28.Text = "G2電圧[V](0V～20V)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "G1電圧[V](-1V～1V)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "プレート電圧[V](0V～20V)";
            // 
            // chartCurveResult
            // 
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.Maximum = 20D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "プレート電圧(V)";
            chartArea3.AxisY.Title = "プレート電流(mA)";
            chartArea3.Name = "ChartArea1";
            this.chartCurveResult.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCurveResult.Legends.Add(legend3);
            this.chartCurveResult.Location = new System.Drawing.Point(6, 158);
            this.chartCurveResult.Name = "chartCurveResult";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.CustomProperties = "IsXAxisQuantitative=True";
            series3.EmptyPointStyle.MarkerBorderColor = System.Drawing.Color.Blue;
            series3.EmptyPointStyle.MarkerColor = System.Drawing.Color.Lime;
            series3.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartCurveResult.Series.Add(series3);
            this.chartCurveResult.Size = new System.Drawing.Size(475, 329);
            this.chartCurveResult.TabIndex = 5;
            this.chartCurveResult.Text = "chart1";
            // 
            // lvCurveResult
            // 
            this.lvCurveResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvCurveResult.HideSelection = false;
            this.lvCurveResult.Location = new System.Drawing.Point(487, 158);
            this.lvCurveResult.Name = "lvCurveResult";
            this.lvCurveResult.Size = new System.Drawing.Size(273, 329);
            this.lvCurveResult.TabIndex = 6;
            this.lvCurveResult.UseCompatibleStateImageBehavior = false;
            this.lvCurveResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "プレート電圧";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "プレート電流";
            this.columnHeader2.Width = 120;
            // 
            // cmbPortSelect
            // 
            this.cmbPortSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortSelect.FormattingEnabled = true;
            this.cmbPortSelect.Location = new System.Drawing.Point(75, 12);
            this.cmbPortSelect.Name = "cmbPortSelect";
            this.cmbPortSelect.Size = new System.Drawing.Size(286, 20);
            this.cmbPortSelect.TabIndex = 0;
            // 
            // btnSetCommPort
            // 
            this.btnSetCommPort.Location = new System.Drawing.Point(367, 6);
            this.btnSetCommPort.Name = "btnSetCommPort";
            this.btnSetCommPort.Size = new System.Drawing.Size(80, 31);
            this.btnSetCommPort.TabIndex = 1;
            this.btnSetCommPort.Text = "ポート更新";
            this.btnSetCommPort.UseVisualStyleBackColor = true;
            this.btnSetCommPort.Click += new System.EventHandler(this.btnSetCommPorts_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 12);
            this.label18.TabIndex = 9;
            this.label18.Text = "ポート選択";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.ReadTimeout = 3000;
            this.serialPort1.WriteTimeout = 3000;
            // 
            // btnOpenLogWindow
            // 
            this.btnOpenLogWindow.Location = new System.Drawing.Point(706, 12);
            this.btnOpenLogWindow.Name = "btnOpenLogWindow";
            this.btnOpenLogWindow.Size = new System.Drawing.Size(82, 36);
            this.btnOpenLogWindow.TabIndex = 2;
            this.btnOpenLogWindow.Text = "ログ表示";
            this.btnOpenLogWindow.UseVisualStyleBackColor = true;
            this.btnOpenLogWindow.Click += new System.EventHandler(this.btnOpenLogWindow_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 519);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.chartCurveResult);
            this.tabPage1.Controls.Add(this.lvCurveResult);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "カーブ計測";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "動作確認";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnShowLoadLine);
            this.groupBox5.Controls.Add(this.btnHideLoadLine);
            this.groupBox5.Controls.Add(this.txtLoadLineResister);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.txtLoadLineVoltage);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Location = new System.Drawing.Point(487, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 145);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "負荷直線";
            // 
            // txtLoadLineVoltage
            // 
            this.txtLoadLineVoltage.Location = new System.Drawing.Point(89, 25);
            this.txtLoadLineVoltage.Name = "txtLoadLineVoltage";
            this.txtLoadLineVoltage.Size = new System.Drawing.Size(64, 19);
            this.txtLoadLineVoltage.TabIndex = 5;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 28);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(65, 12);
            this.label29.TabIndex = 2;
            this.label29.Text = "プレート電圧";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(30, 53);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 12);
            this.label30.TabIndex = 2;
            this.label30.Text = "負荷抵抗";
            // 
            // txtLoadLineResister
            // 
            this.txtLoadLineResister.Location = new System.Drawing.Point(89, 50);
            this.txtLoadLineResister.Name = "txtLoadLineResister";
            this.txtLoadLineResister.Size = new System.Drawing.Size(64, 19);
            this.txtLoadLineResister.TabIndex = 5;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(159, 28);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(13, 12);
            this.label31.TabIndex = 2;
            this.label31.Text = "V";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(159, 53);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(23, 12);
            this.label32.TabIndex = 2;
            this.label32.Text = "kΩ";
            // 
            // btnHideLoadLine
            // 
            this.btnHideLoadLine.Location = new System.Drawing.Point(27, 88);
            this.btnHideLoadLine.Name = "btnHideLoadLine";
            this.btnHideLoadLine.Size = new System.Drawing.Size(62, 36);
            this.btnHideLoadLine.TabIndex = 6;
            this.btnHideLoadLine.Text = "消去";
            this.btnHideLoadLine.UseVisualStyleBackColor = true;
            this.btnHideLoadLine.Click += new System.EventHandler(this.btnHideLoadLine_Click);
            // 
            // btnShowLoadLine
            // 
            this.btnShowLoadLine.Location = new System.Drawing.Point(110, 88);
            this.btnShowLoadLine.Name = "btnShowLoadLine";
            this.btnShowLoadLine.Size = new System.Drawing.Size(62, 36);
            this.btnShowLoadLine.TabIndex = 6;
            this.btnShowLoadLine.Text = "表示";
            this.btnShowLoadLine.UseVisualStyleBackColor = true;
            this.btnShowLoadLine.Click += new System.EventHandler(this.btnShowLoadLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOpenLogWindow);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnSetCommPort);
            this.Controls.Add(this.cmbPortSelect);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Electron Tube Curve Tracer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCurveResult)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoTubeSelectTriode;
        private System.Windows.Forms.RadioButton rdoTubeSelectPentode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPlateCurrentRead;
        private System.Windows.Forms.TextBox txtPlateVoltageRead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtG1VoltageRead;
        private System.Windows.Forms.TextBox txtG2VoltageRead;
        private System.Windows.Forms.TextBox txtHeaterCurrentRead;
        private System.Windows.Forms.TextBox txtHeaterVoltageRead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtG2VoltageSet;
        private System.Windows.Forms.TextBox txtG1VoltageSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPlateVoltageSet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSetDA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnStartMeasureCurve;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGridVoltageStep;
        private System.Windows.Forms.TextBox txtPlateVoltageStep;
        private System.Windows.Forms.TextBox txtGridVoltageLast;
        private System.Windows.Forms.TextBox txtPlateVoltageLast;
        private System.Windows.Forms.TextBox txtGridVoltageInitial;
        private System.Windows.Forms.TextBox txtPlateVoltageInitial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCurveResult;
        private System.Windows.Forms.ListView lvCurveResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnMeasure;
        private System.Windows.Forms.ComboBox cmbPortSelect;
        private System.Windows.Forms.Button btnSetCommPort;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox chkCurveRunning;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnOpenLogWindow;
        private System.Windows.Forms.TextBox txtGrid2VoltageCurve;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnShowLoadLine;
        private System.Windows.Forms.Button btnHideLoadLine;
        private System.Windows.Forms.TextBox txtLoadLineResister;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtLoadLineVoltage;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
    }
}

