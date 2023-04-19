namespace HaiApi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtJson = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnGet = new System.Windows.Forms.Button();
            this.TxtURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtConc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtSearchTaskCode = new System.Windows.Forms.TextBox();
            this.TxtSearchTHMCode = new System.Windows.Forms.TextBox();
            this.TxtSearchBusinessType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearchOrderCode = new System.Windows.Forms.TextBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnData = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnJson = new System.Windows.Forms.Button();
            this.BtnInboundIla = new System.Windows.Forms.Button();
            this.BtnOutboundIla = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtInboundOrderCode = new System.Windows.Forms.TextBox();
            this.TxtInboundGoodsInId = new System.Windows.Forms.TextBox();
            this.TxtInboundTaskCode = new System.Windows.Forms.TextBox();
            this.TxtInboundProductId = new System.Windows.Forms.TextBox();
            this.TxtInboundTHMCode = new System.Windows.Forms.TextBox();
            this.TxtInboundQty = new System.Windows.Forms.TextBox();
            this.BtnInboundCreate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnOutboundCreate = new System.Windows.Forms.Button();
            this.TxtOutboundQTY = new System.Windows.Forms.TextBox();
            this.TxtOutboundTHMCode = new System.Windows.Forms.TextBox();
            this.TxtOutboundProductId = new System.Windows.Forms.TextBox();
            this.TxtOutboundTaskCode = new System.Windows.Forms.TextBox();
            this.TxtOutboundGoodsInId = new System.Windows.Forms.TextBox();
            this.TxtOutboundOrderCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtInboundWorkStationId = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtJson
            // 
            this.TxtJson.Location = new System.Drawing.Point(0, 69);
            this.TxtJson.Multiline = true;
            this.TxtJson.Name = "TxtJson";
            this.TxtJson.Size = new System.Drawing.Size(1232, 248);
            this.TxtJson.TabIndex = 0;
            // 
            // BtnSend
            // 
            this.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSend.Location = new System.Drawing.Point(1158, 25);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 38);
            this.BtnSend.TabIndex = 1;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // BtnGet
            // 
            this.BtnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGet.Location = new System.Drawing.Point(1077, 25);
            this.BtnGet.Name = "BtnGet";
            this.BtnGet.Size = new System.Drawing.Size(75, 38);
            this.BtnGet.TabIndex = 2;
            this.BtnGet.Text = "Get";
            this.BtnGet.UseVisualStyleBackColor = true;
            this.BtnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // TxtURL
            // 
            this.TxtURL.Location = new System.Drawing.Point(2, 25);
            this.TxtURL.Name = "TxtURL";
            this.TxtURL.Size = new System.Drawing.Size(272, 23);
            this.TxtURL.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "JSON";
            // 
            // TxtConc
            // 
            this.TxtConc.Location = new System.Drawing.Point(0, 323);
            this.TxtConc.Multiline = true;
            this.TxtConc.Name = "TxtConc";
            this.TxtConc.Size = new System.Drawing.Size(1232, 72);
            this.TxtConc.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtSearchTaskCode);
            this.panel1.Controls.Add(this.TxtSearchTHMCode);
            this.panel1.Controls.Add(this.TxtSearchBusinessType);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtSearchOrderCode);
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(10, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 520);
            this.panel1.TabIndex = 9;
            // 
            // TxtSearchTaskCode
            // 
            this.TxtSearchTaskCode.Location = new System.Drawing.Point(438, 30);
            this.TxtSearchTaskCode.Name = "TxtSearchTaskCode";
            this.TxtSearchTaskCode.Size = new System.Drawing.Size(114, 23);
            this.TxtSearchTaskCode.TabIndex = 7;
            // 
            // TxtSearchTHMCode
            // 
            this.TxtSearchTHMCode.Location = new System.Drawing.Point(300, 30);
            this.TxtSearchTHMCode.Name = "TxtSearchTHMCode";
            this.TxtSearchTHMCode.Size = new System.Drawing.Size(114, 23);
            this.TxtSearchTHMCode.TabIndex = 6;
            // 
            // TxtSearchBusinessType
            // 
            this.TxtSearchBusinessType.Location = new System.Drawing.Point(163, 30);
            this.TxtSearchBusinessType.Name = "TxtSearchBusinessType";
            this.TxtSearchBusinessType.Size = new System.Drawing.Size(114, 23);
            this.TxtSearchBusinessType.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "TaskCode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "THMCode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "BusinessType";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "OrderCode";
            // 
            // TxtSearchOrderCode
            // 
            this.TxtSearchOrderCode.Location = new System.Drawing.Point(29, 30);
            this.TxtSearchOrderCode.Name = "TxtSearchOrderCode";
            this.TxtSearchOrderCode.Size = new System.Drawing.Size(114, 23);
            this.TxtSearchOrderCode.TabIndex = 2;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Location = new System.Drawing.Point(1119, 21);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(97, 39);
            this.BtnRefresh.TabIndex = 1;
            this.BtnRefresh.Text = "Getir";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1197, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnData
            // 
            this.BtnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnData.Location = new System.Drawing.Point(93, 12);
            this.BtnData.Name = "BtnData";
            this.BtnData.Size = new System.Drawing.Size(75, 23);
            this.BtnData.TabIndex = 10;
            this.BtnData.Text = "Task Hai";
            this.BtnData.UseVisualStyleBackColor = true;
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnGet);
            this.panel2.Controls.Add(this.BtnSend);
            this.panel2.Controls.Add(this.TxtURL);
            this.panel2.Controls.Add(this.TxtConc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TxtJson);
            this.panel2.Location = new System.Drawing.Point(9, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1244, 397);
            this.panel2.TabIndex = 11;
            // 
            // BtnJson
            // 
            this.BtnJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJson.Location = new System.Drawing.Point(12, 12);
            this.BtnJson.Name = "BtnJson";
            this.BtnJson.Size = new System.Drawing.Size(75, 23);
            this.BtnJson.TabIndex = 12;
            this.BtnJson.Text = "JSON Hai";
            this.BtnJson.UseVisualStyleBackColor = true;
            this.BtnJson.Click += new System.EventHandler(this.BtnJson_Click);
            // 
            // BtnInboundIla
            // 
            this.BtnInboundIla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInboundIla.Location = new System.Drawing.Point(174, 12);
            this.BtnInboundIla.Name = "BtnInboundIla";
            this.BtnInboundIla.Size = new System.Drawing.Size(84, 23);
            this.BtnInboundIla.TabIndex = 14;
            this.BtnInboundIla.Text = "Inbound ILA";
            this.BtnInboundIla.UseVisualStyleBackColor = true;
            this.BtnInboundIla.Click += new System.EventHandler(this.BtnInboundIla_Click);
            // 
            // BtnOutboundIla
            // 
            this.BtnOutboundIla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOutboundIla.Location = new System.Drawing.Point(264, 12);
            this.BtnOutboundIla.Name = "BtnOutboundIla";
            this.BtnOutboundIla.Size = new System.Drawing.Size(94, 23);
            this.BtnOutboundIla.TabIndex = 15;
            this.BtnOutboundIla.Text = "Outbound ILA";
            this.BtnOutboundIla.UseVisualStyleBackColor = true;
            this.BtnOutboundIla.Click += new System.EventHandler(this.BtnOutboundIla_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Order Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "GoodsInId";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "TaskCode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "ProductId";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "THMCode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "QTY";
            // 
            // TxtInboundOrderCode
            // 
            this.TxtInboundOrderCode.Location = new System.Drawing.Point(107, 35);
            this.TxtInboundOrderCode.Name = "TxtInboundOrderCode";
            this.TxtInboundOrderCode.Size = new System.Drawing.Size(187, 23);
            this.TxtInboundOrderCode.TabIndex = 4;
            // 
            // TxtInboundGoodsInId
            // 
            this.TxtInboundGoodsInId.Location = new System.Drawing.Point(107, 123);
            this.TxtInboundGoodsInId.Name = "TxtInboundGoodsInId";
            this.TxtInboundGoodsInId.Size = new System.Drawing.Size(187, 23);
            this.TxtInboundGoodsInId.TabIndex = 5;
            // 
            // TxtInboundTaskCode
            // 
            this.TxtInboundTaskCode.Location = new System.Drawing.Point(107, 173);
            this.TxtInboundTaskCode.Name = "TxtInboundTaskCode";
            this.TxtInboundTaskCode.Size = new System.Drawing.Size(187, 23);
            this.TxtInboundTaskCode.TabIndex = 6;
            // 
            // TxtInboundProductId
            // 
            this.TxtInboundProductId.Location = new System.Drawing.Point(107, 227);
            this.TxtInboundProductId.Name = "TxtInboundProductId";
            this.TxtInboundProductId.Size = new System.Drawing.Size(187, 23);
            this.TxtInboundProductId.TabIndex = 7;
            // 
            // TxtInboundTHMCode
            // 
            this.TxtInboundTHMCode.Location = new System.Drawing.Point(108, 352);
            this.TxtInboundTHMCode.Name = "TxtInboundTHMCode";
            this.TxtInboundTHMCode.Size = new System.Drawing.Size(187, 23);
            this.TxtInboundTHMCode.TabIndex = 8;
            // 
            // TxtInboundQty
            // 
            this.TxtInboundQty.Location = new System.Drawing.Point(108, 396);
            this.TxtInboundQty.Name = "TxtInboundQty";
            this.TxtInboundQty.Size = new System.Drawing.Size(187, 23);
            this.TxtInboundQty.TabIndex = 9;
            // 
            // BtnInboundCreate
            // 
            this.BtnInboundCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInboundCreate.Location = new System.Drawing.Point(20, 440);
            this.BtnInboundCreate.Name = "BtnInboundCreate";
            this.BtnInboundCreate.Size = new System.Drawing.Size(275, 30);
            this.BtnInboundCreate.TabIndex = 10;
            this.BtnInboundCreate.Text = "Create Inbound";
            this.BtnInboundCreate.UseVisualStyleBackColor = true;
            this.BtnInboundCreate.Click += new System.EventHandler(this.BtnInboundCreate_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.TxtInboundWorkStationId);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.BtnInboundCreate);
            this.panel3.Controls.Add(this.TxtInboundQty);
            this.panel3.Controls.Add(this.TxtInboundTHMCode);
            this.panel3.Controls.Add(this.TxtInboundProductId);
            this.panel3.Controls.Add(this.TxtInboundTaskCode);
            this.panel3.Controls.Add(this.TxtInboundGoodsInId);
            this.panel3.Controls.Add(this.TxtInboundOrderCode);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(9, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1232, 558);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnOutboundCreate);
            this.panel4.Controls.Add(this.TxtOutboundQTY);
            this.panel4.Controls.Add(this.TxtOutboundTHMCode);
            this.panel4.Controls.Add(this.TxtOutboundProductId);
            this.panel4.Controls.Add(this.TxtOutboundTaskCode);
            this.panel4.Controls.Add(this.TxtOutboundGoodsInId);
            this.panel4.Controls.Add(this.TxtOutboundOrderCode);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Location = new System.Drawing.Point(20, 632);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1233, 558);
            this.panel4.TabIndex = 16;
            // 
            // BtnOutboundCreate
            // 
            this.BtnOutboundCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOutboundCreate.Location = new System.Drawing.Point(16, 322);
            this.BtnOutboundCreate.Name = "BtnOutboundCreate";
            this.BtnOutboundCreate.Size = new System.Drawing.Size(278, 31);
            this.BtnOutboundCreate.TabIndex = 16;
            this.BtnOutboundCreate.Text = "Create Outbound";
            this.BtnOutboundCreate.UseVisualStyleBackColor = true;
            // 
            // TxtOutboundQTY
            // 
            this.TxtOutboundQTY.Location = new System.Drawing.Point(107, 274);
            this.TxtOutboundQTY.Name = "TxtOutboundQTY";
            this.TxtOutboundQTY.Size = new System.Drawing.Size(187, 23);
            this.TxtOutboundQTY.TabIndex = 15;
            // 
            // TxtOutboundTHMCode
            // 
            this.TxtOutboundTHMCode.Location = new System.Drawing.Point(107, 227);
            this.TxtOutboundTHMCode.Name = "TxtOutboundTHMCode";
            this.TxtOutboundTHMCode.Size = new System.Drawing.Size(187, 23);
            this.TxtOutboundTHMCode.TabIndex = 14;
            // 
            // TxtOutboundProductId
            // 
            this.TxtOutboundProductId.Location = new System.Drawing.Point(107, 180);
            this.TxtOutboundProductId.Name = "TxtOutboundProductId";
            this.TxtOutboundProductId.Size = new System.Drawing.Size(187, 23);
            this.TxtOutboundProductId.TabIndex = 13;
            // 
            // TxtOutboundTaskCode
            // 
            this.TxtOutboundTaskCode.Location = new System.Drawing.Point(107, 126);
            this.TxtOutboundTaskCode.Name = "TxtOutboundTaskCode";
            this.TxtOutboundTaskCode.Size = new System.Drawing.Size(187, 23);
            this.TxtOutboundTaskCode.TabIndex = 12;
            // 
            // TxtOutboundGoodsInId
            // 
            this.TxtOutboundGoodsInId.Location = new System.Drawing.Point(107, 81);
            this.TxtOutboundGoodsInId.Name = "TxtOutboundGoodsInId";
            this.TxtOutboundGoodsInId.Size = new System.Drawing.Size(187, 23);
            this.TxtOutboundGoodsInId.TabIndex = 11;
            // 
            // TxtOutboundOrderCode
            // 
            this.TxtOutboundOrderCode.Location = new System.Drawing.Point(107, 30);
            this.TxtOutboundOrderCode.Name = "TxtOutboundOrderCode";
            this.TxtOutboundOrderCode.Size = new System.Drawing.Size(187, 23);
            this.TxtOutboundOrderCode.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "QTY";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "THMCode";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 15);
            this.label15.TabIndex = 7;
            this.label15.Text = "ProductId";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 15);
            this.label16.TabIndex = 4;
            this.label16.Text = "TaskCode";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "GoodsInId";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 15);
            this.label18.TabIndex = 6;
            this.label18.Text = "Order Code";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(538, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 15);
            this.label20.TabIndex = 11;
            this.label20.Text = "Inbound";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "WorkStationId";
            // 
            // TxtInboundWorkStationId
            // 
            this.TxtInboundWorkStationId.Location = new System.Drawing.Point(107, 81);
            this.TxtInboundWorkStationId.Name = "TxtInboundWorkStationId";
            this.TxtInboundWorkStationId.Size = new System.Drawing.Size(187, 23);
            this.TxtInboundWorkStationId.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 278);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 281);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 15);
            this.label21.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 666);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.BtnOutboundIla);
            this.Controls.Add(this.BtnInboundIla);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnJson);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnData);
            this.Name = "Form1";
            this.Text = "Api";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox TxtJson;
        private Button BtnSend;
        private Button BtnGet;
        private TextBox TxtURL;
        private Label label2;
        private Label label3;
        private TextBox TxtConc;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button BtnRefresh;
        private Button BtnData;
        private Panel panel2;
        private Button BtnJson;
        private TextBox TxtSearchTaskCode;
        private TextBox TxtSearchTHMCode;
        private TextBox TxtSearchBusinessType;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox TxtSearchOrderCode;
        private Button BtnInboundIla;
        private Button BtnOutboundIla;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox TxtInboundOrderCode;
        private TextBox TxtInboundGoodsInId;
        private TextBox TxtInboundTaskCode;
        private TextBox TxtInboundProductId;
        private TextBox TxtInboundTHMCode;
        private TextBox TxtInboundQty;
        private Button BtnInboundCreate;
        private Panel panel3;
        private Panel panel4;
        private Label label20;
        private Button BtnOutboundCreate;
        private TextBox TxtOutboundQTY;
        private TextBox TxtOutboundTHMCode;
        private TextBox TxtOutboundProductId;
        private TextBox TxtOutboundTaskCode;
        private TextBox TxtOutboundGoodsInId;
        private TextBox TxtOutboundOrderCode;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox TxtInboundWorkStationId;
        private Label label19;
        private Label label21;
        private ComboBox comboBox1;
    }
}