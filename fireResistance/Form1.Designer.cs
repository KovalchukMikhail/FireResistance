namespace fireResistance
{
    partial class LableFireResistanceForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LableFireResistanceForm));
            this.comboBoxFireResistanceLimit = new System.Windows.Forms.ComboBox();
            this.LablefireResistanceLimit = new System.Windows.Forms.Label();
            this.labelLenthElement = new System.Windows.Forms.Label();
            this.textBoxLenthElement = new System.Windows.Forms.TextBox();
            this.labelLenthInmm = new System.Windows.Forms.Label();
            this.labelHeightInmm = new System.Windows.Forms.Label();
            this.textBoxHeightElement = new System.Windows.Forms.TextBox();
            this.labelHeightElement = new System.Windows.Forms.Label();
            this.labelWidthInmm = new System.Windows.Forms.Label();
            this.textBoxWidthElement = new System.Windows.Forms.TextBox();
            this.labelWidthElement = new System.Windows.Forms.Label();
            this.labelFixationElement = new System.Windows.Forms.Label();
            this.comboBoxFixationElement = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAInmm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLenth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelArmatureClass = new System.Windows.Forms.Label();
            this.comboBoxArmatureClass = new System.Windows.Forms.ComboBox();
            this.labelConcreteClass = new System.Windows.Forms.Label();
            this.comboBoxConcreteClass = new System.Windows.Forms.ComboBox();
            this.labelArmatureDiameter = new System.Windows.Forms.Label();
            this.comboBoxArmatureDiameter = new System.Windows.Forms.ComboBox();
            this.labelArmatureAmount = new System.Windows.Forms.Label();
            this.comboBoxArmatureAmount = new System.Windows.Forms.ComboBox();
            this.labelMomentSign = new System.Windows.Forms.Label();
            this.labelMomentTxM = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelMoment = new System.Windows.Forms.Label();
            this.labellabelStrengthSign = new System.Windows.Forms.Label();
            this.labelStrengthT = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelStrength = new System.Windows.Forms.Label();
            this.labelConcreteType = new System.Windows.Forms.Label();
            this.comboBoxConcreteType = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonСalculation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFireResistanceLimit
            // 
            this.comboBoxFireResistanceLimit.FormattingEnabled = true;
            this.comboBoxFireResistanceLimit.Items.AddRange(new object[] {
            "R15",
            "R30",
            "R45",
            "R60",
            "R90",
            "R120",
            "R150"});
            this.comboBoxFireResistanceLimit.Location = new System.Drawing.Point(17, 40);
            this.comboBoxFireResistanceLimit.Name = "comboBoxFireResistanceLimit";
            this.comboBoxFireResistanceLimit.Size = new System.Drawing.Size(80, 24);
            this.comboBoxFireResistanceLimit.TabIndex = 0;
            this.comboBoxFireResistanceLimit.Text = "R120";
            this.comboBoxFireResistanceLimit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LablefireResistanceLimit
            // 
            this.LablefireResistanceLimit.AutoSize = true;
            this.LablefireResistanceLimit.Location = new System.Drawing.Point(14, 21);
            this.LablefireResistanceLimit.Name = "LablefireResistanceLimit";
            this.LablefireResistanceLimit.Size = new System.Drawing.Size(299, 16);
            this.LablefireResistanceLimit.TabIndex = 1;
            this.LablefireResistanceLimit.Text = "Выберете требуемый предел огнестойкости";
            // 
            // labelLenthElement
            // 
            this.labelLenthElement.AutoSize = true;
            this.labelLenthElement.Location = new System.Drawing.Point(13, 67);
            this.labelLenthElement.Name = "labelLenthElement";
            this.labelLenthElement.Size = new System.Drawing.Size(173, 16);
            this.labelLenthElement.TabIndex = 2;
            this.labelLenthElement.Text = "Укажите длину элемента";
            // 
            // textBoxLenthElement
            // 
            this.textBoxLenthElement.Location = new System.Drawing.Point(60, 86);
            this.textBoxLenthElement.Name = "textBoxLenthElement";
            this.textBoxLenthElement.Size = new System.Drawing.Size(100, 22);
            this.textBoxLenthElement.TabIndex = 3;
            // 
            // labelLenthInmm
            // 
            this.labelLenthInmm.AutoSize = true;
            this.labelLenthInmm.Location = new System.Drawing.Point(170, 94);
            this.labelLenthInmm.Name = "labelLenthInmm";
            this.labelLenthInmm.Size = new System.Drawing.Size(25, 16);
            this.labelLenthInmm.TabIndex = 4;
            this.labelLenthInmm.Text = "мм";
            this.labelLenthInmm.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelHeightInmm
            // 
            this.labelHeightInmm.AutoSize = true;
            this.labelHeightInmm.Location = new System.Drawing.Point(170, 141);
            this.labelHeightInmm.Name = "labelHeightInmm";
            this.labelHeightInmm.Size = new System.Drawing.Size(25, 16);
            this.labelHeightInmm.TabIndex = 7;
            this.labelHeightInmm.Text = "мм";
            this.labelHeightInmm.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxHeightElement
            // 
            this.textBoxHeightElement.Location = new System.Drawing.Point(60, 135);
            this.textBoxHeightElement.Name = "textBoxHeightElement";
            this.textBoxHeightElement.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeightElement.TabIndex = 6;
            this.textBoxHeightElement.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelHeightElement
            // 
            this.labelHeightElement.AutoSize = true;
            this.labelHeightElement.Location = new System.Drawing.Point(15, 114);
            this.labelHeightElement.Name = "labelHeightElement";
            this.labelHeightElement.Size = new System.Drawing.Size(180, 16);
            this.labelHeightElement.TabIndex = 5;
            this.labelHeightElement.Text = "Укажите высоту элемента";
            this.labelHeightElement.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelWidthInmm
            // 
            this.labelWidthInmm.AutoSize = true;
            this.labelWidthInmm.Location = new System.Drawing.Point(170, 186);
            this.labelWidthInmm.Name = "labelWidthInmm";
            this.labelWidthInmm.Size = new System.Drawing.Size(25, 16);
            this.labelWidthInmm.TabIndex = 10;
            this.labelWidthInmm.Text = "мм";
            // 
            // textBoxWidthElement
            // 
            this.textBoxWidthElement.Location = new System.Drawing.Point(60, 179);
            this.textBoxWidthElement.Name = "textBoxWidthElement";
            this.textBoxWidthElement.Size = new System.Drawing.Size(100, 22);
            this.textBoxWidthElement.TabIndex = 9;
            // 
            // labelWidthElement
            // 
            this.labelWidthElement.AutoSize = true;
            this.labelWidthElement.Location = new System.Drawing.Point(16, 159);
            this.labelWidthElement.Name = "labelWidthElement";
            this.labelWidthElement.Size = new System.Drawing.Size(182, 16);
            this.labelWidthElement.TabIndex = 8;
            this.labelWidthElement.Text = "Укажите ширину элемента";
            // 
            // labelFixationElement
            // 
            this.labelFixationElement.AutoSize = true;
            this.labelFixationElement.Location = new System.Drawing.Point(17, 248);
            this.labelFixationElement.Name = "labelFixationElement";
            this.labelFixationElement.Size = new System.Drawing.Size(356, 16);
            this.labelFixationElement.TabIndex = 12;
            this.labelFixationElement.Text = "Выберите вариант закрепления по концам элемента";
            // 
            // comboBoxFixationElement
            // 
            this.comboBoxFixationElement.FormattingEnabled = true;
            this.comboBoxFixationElement.Items.AddRange(new object[] {
            "1. Не смещаемая заделка на двух концах",
            "2. Не смещаемая заделка на двух концах с податливым ограниченным поворотом",
            "3. Шарнирные опоры на двух концах"});
            this.comboBoxFixationElement.Location = new System.Drawing.Point(20, 267);
            this.comboBoxFixationElement.Name = "comboBoxFixationElement";
            this.comboBoxFixationElement.Size = new System.Drawing.Size(600, 24);
            this.comboBoxFixationElement.TabIndex = 11;
            this.comboBoxFixationElement.Text = "1. Не смещаемая заделка на двух концах";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(466, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // labelAInmm
            // 
            this.labelAInmm.AutoSize = true;
            this.labelAInmm.Location = new System.Drawing.Point(170, 230);
            this.labelAInmm.Name = "labelAInmm";
            this.labelAInmm.Size = new System.Drawing.Size(25, 16);
            this.labelAInmm.TabIndex = 16;
            this.labelAInmm.Text = "мм";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Укажите расстояние от грани элемента до центра тяжести арматуры";
            // 
            // labelLenth
            // 
            this.labelLenth.AutoSize = true;
            this.labelLenth.Location = new System.Drawing.Point(30, 92);
            this.labelLenth.Name = "labelLenth";
            this.labelLenth.Size = new System.Drawing.Size(24, 16);
            this.labelLenth.TabIndex = 17;
            this.labelLenth.Text = "L =";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(30, 141);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(24, 16);
            this.labelHeight.TabIndex = 18;
            this.labelHeight.Text = "h =";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(30, 185);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(25, 16);
            this.labelWidth.TabIndex = 19;
            this.labelWidth.Text = "b =";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(29, 229);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(25, 16);
            this.labelA.TabIndex = 20;
            this.labelA.Text = "a =";
            // 
            // labelArmatureClass
            // 
            this.labelArmatureClass.AutoSize = true;
            this.labelArmatureClass.Location = new System.Drawing.Point(17, 294);
            this.labelArmatureClass.Name = "labelArmatureClass";
            this.labelArmatureClass.Size = new System.Drawing.Size(272, 16);
            this.labelArmatureClass.TabIndex = 22;
            this.labelArmatureClass.Text = "Выберите класс арматуры по прочности";
            // 
            // comboBoxArmatureClass
            // 
            this.comboBoxArmatureClass.FormattingEnabled = true;
            this.comboBoxArmatureClass.Items.AddRange(new object[] {
            "А240",
            "А400",
            "А500",
            "А600",
            "А800",
            "А1000",
            "В500",
            "А500с марка 25Г2С по ГОСТ Р 52544-2006",
            "А600С марки 18Г2СФ термомеханически упрочненная",
            "А500С марки Ст3Гпс термомеханически упрочненная по ГОСТ 34028-2016"});
            this.comboBoxArmatureClass.Location = new System.Drawing.Point(20, 313);
            this.comboBoxArmatureClass.Name = "comboBoxArmatureClass";
            this.comboBoxArmatureClass.Size = new System.Drawing.Size(600, 24);
            this.comboBoxArmatureClass.TabIndex = 21;
            this.comboBoxArmatureClass.Text = "А500С марки Ст3Гпс термомеханически упрочненная по ГОСТ 34028-2016";
            // 
            // labelConcreteClass
            // 
            this.labelConcreteClass.AutoSize = true;
            this.labelConcreteClass.Location = new System.Drawing.Point(17, 386);
            this.labelConcreteClass.Name = "labelConcreteClass";
            this.labelConcreteClass.Size = new System.Drawing.Size(254, 16);
            this.labelConcreteClass.TabIndex = 24;
            this.labelConcreteClass.Text = "Выберите класс бетона по прочности";
            this.labelConcreteClass.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBoxConcreteClass
            // 
            this.comboBoxConcreteClass.FormattingEnabled = true;
            this.comboBoxConcreteClass.Items.AddRange(new object[] {
            "B15",
            "B20",
            "B25",
            "B30",
            "B35",
            "B40",
            "B45",
            "B50"});
            this.comboBoxConcreteClass.Location = new System.Drawing.Point(20, 405);
            this.comboBoxConcreteClass.Name = "comboBoxConcreteClass";
            this.comboBoxConcreteClass.Size = new System.Drawing.Size(80, 24);
            this.comboBoxConcreteClass.TabIndex = 23;
            this.comboBoxConcreteClass.Text = "B30";
            this.comboBoxConcreteClass.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // labelArmatureDiameter
            // 
            this.labelArmatureDiameter.AutoSize = true;
            this.labelArmatureDiameter.Location = new System.Drawing.Point(17, 432);
            this.labelArmatureDiameter.Name = "labelArmatureDiameter";
            this.labelArmatureDiameter.Size = new System.Drawing.Size(199, 16);
            this.labelArmatureDiameter.TabIndex = 26;
            this.labelArmatureDiameter.Text = "Выберите диаметр арматуры";
            // 
            // comboBoxArmatureDiameter
            // 
            this.comboBoxArmatureDiameter.FormattingEnabled = true;
            this.comboBoxArmatureDiameter.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "25",
            "28",
            "32",
            "36",
            "40"});
            this.comboBoxArmatureDiameter.Location = new System.Drawing.Point(20, 451);
            this.comboBoxArmatureDiameter.Name = "comboBoxArmatureDiameter";
            this.comboBoxArmatureDiameter.Size = new System.Drawing.Size(80, 24);
            this.comboBoxArmatureDiameter.TabIndex = 25;
            this.comboBoxArmatureDiameter.Text = "10";
            // 
            // labelArmatureAmount
            // 
            this.labelArmatureAmount.AutoSize = true;
            this.labelArmatureAmount.Location = new System.Drawing.Point(17, 478);
            this.labelArmatureAmount.Name = "labelArmatureAmount";
            this.labelArmatureAmount.Size = new System.Drawing.Size(300, 16);
            this.labelArmatureAmount.TabIndex = 28;
            this.labelArmatureAmount.Text = "Выберите количество арматурных стержней";
            // 
            // comboBoxArmatureAmount
            // 
            this.comboBoxArmatureAmount.FormattingEnabled = true;
            this.comboBoxArmatureAmount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxArmatureAmount.Location = new System.Drawing.Point(20, 497);
            this.comboBoxArmatureAmount.Name = "comboBoxArmatureAmount";
            this.comboBoxArmatureAmount.Size = new System.Drawing.Size(80, 24);
            this.comboBoxArmatureAmount.TabIndex = 27;
            this.comboBoxArmatureAmount.Text = "2";
            // 
            // labelMomentSign
            // 
            this.labelMomentSign.AutoSize = true;
            this.labelMomentSign.Location = new System.Drawing.Point(35, 550);
            this.labelMomentSign.Name = "labelMomentSign";
            this.labelMomentSign.Size = new System.Drawing.Size(28, 16);
            this.labelMomentSign.TabIndex = 32;
            this.labelMomentSign.Text = "M =";
            // 
            // labelMomentTxM
            // 
            this.labelMomentTxM.AutoSize = true;
            this.labelMomentTxM.Location = new System.Drawing.Point(175, 552);
            this.labelMomentTxM.Name = "labelMomentTxM";
            this.labelMomentTxM.Size = new System.Drawing.Size(28, 16);
            this.labelMomentTxM.TabIndex = 31;
            this.labelMomentTxM.Text = "т*м";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 543);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 30;
            // 
            // labelMoment
            // 
            this.labelMoment.AutoSize = true;
            this.labelMoment.Location = new System.Drawing.Point(17, 524);
            this.labelMoment.Name = "labelMoment";
            this.labelMoment.Size = new System.Drawing.Size(625, 16);
            this.labelMoment.TabIndex = 29;
            this.labelMoment.Text = "Укажите величину изгибающего момента от постоянной и длительной нормативной нагру" +
    "зки";
            // 
            // labellabelStrengthSign
            // 
            this.labellabelStrengthSign.AutoSize = true;
            this.labellabelStrengthSign.Location = new System.Drawing.Point(36, 595);
            this.labellabelStrengthSign.Name = "labellabelStrengthSign";
            this.labellabelStrengthSign.Size = new System.Drawing.Size(27, 16);
            this.labellabelStrengthSign.TabIndex = 36;
            this.labellabelStrengthSign.Text = "N =";
            this.labellabelStrengthSign.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labelStrengthT
            // 
            this.labelStrengthT.AutoSize = true;
            this.labelStrengthT.Location = new System.Drawing.Point(176, 597);
            this.labelStrengthT.Name = "labelStrengthT";
            this.labelStrengthT.Size = new System.Drawing.Size(14, 16);
            this.labelStrengthT.TabIndex = 35;
            this.labelStrengthT.Text = "т";
            this.labelStrengthT.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(64, 587);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 34;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Location = new System.Drawing.Point(17, 568);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(593, 16);
            this.labelStrength.TabIndex = 33;
            this.labelStrength.Text = "Укажите величину нормальной силы от постоянной и длительной нормативной нагрузки";
            this.labelStrength.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelConcreteType
            // 
            this.labelConcreteType.AutoSize = true;
            this.labelConcreteType.Location = new System.Drawing.Point(17, 340);
            this.labelConcreteType.Name = "labelConcreteType";
            this.labelConcreteType.Size = new System.Drawing.Size(149, 16);
            this.labelConcreteType.TabIndex = 38;
            this.labelConcreteType.Text = "Выберите вид бетона";
            // 
            // comboBoxConcreteType
            // 
            this.comboBoxConcreteType.FormattingEnabled = true;
            this.comboBoxConcreteType.Items.AddRange(new object[] {
            "Тяжелый, на силикатном заполнителе",
            "Тяжелый, на карбонатном заполнителе",
            "Конструкционный керамзитобетон"});
            this.comboBoxConcreteType.Location = new System.Drawing.Point(21, 360);
            this.comboBoxConcreteType.Name = "comboBoxConcreteType";
            this.comboBoxConcreteType.Size = new System.Drawing.Size(600, 24);
            this.comboBoxConcreteType.TabIndex = 37;
            this.comboBoxConcreteType.Text = "Тяжелый, на силикатном заполнителе";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(510, 621);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 30);
            this.buttonCancel.TabIndex = 39;
            this.buttonCancel.Text = "Выход";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonСalculation
            // 
            this.buttonСalculation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonСalculation.Location = new System.Drawing.Point(304, 621);
            this.buttonСalculation.Name = "buttonСalculation";
            this.buttonСalculation.Size = new System.Drawing.Size(200, 30);
            this.buttonСalculation.TabIndex = 40;
            this.buttonСalculation.Text = "Расчет";
            this.buttonСalculation.UseVisualStyleBackColor = true;
            // 
            // LableFireResistanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(642, 663);
            this.Controls.Add(this.buttonСalculation);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelConcreteType);
            this.Controls.Add(this.comboBoxConcreteType);
            this.Controls.Add(this.labellabelStrengthSign);
            this.Controls.Add(this.labelStrengthT);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.labelMomentSign);
            this.Controls.Add(this.labelMomentTxM);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelMoment);
            this.Controls.Add(this.labelArmatureAmount);
            this.Controls.Add(this.comboBoxArmatureAmount);
            this.Controls.Add(this.labelArmatureDiameter);
            this.Controls.Add(this.comboBoxArmatureDiameter);
            this.Controls.Add(this.labelConcreteClass);
            this.Controls.Add(this.comboBoxConcreteClass);
            this.Controls.Add(this.labelArmatureClass);
            this.Controls.Add(this.comboBoxArmatureClass);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelLenth);
            this.Controls.Add(this.labelAInmm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelFixationElement);
            this.Controls.Add(this.comboBoxFixationElement);
            this.Controls.Add(this.labelWidthInmm);
            this.Controls.Add(this.textBoxWidthElement);
            this.Controls.Add(this.labelWidthElement);
            this.Controls.Add(this.labelHeightInmm);
            this.Controls.Add(this.textBoxHeightElement);
            this.Controls.Add(this.labelHeightElement);
            this.Controls.Add(this.labelLenthInmm);
            this.Controls.Add(this.textBoxLenthElement);
            this.Controls.Add(this.labelLenthElement);
            this.Controls.Add(this.LablefireResistanceLimit);
            this.Controls.Add(this.comboBoxFireResistanceLimit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LableFireResistanceForm";
            this.Text = "Проверка предела огнестойкости";
            this.Load += new System.EventHandler(this.LableMetr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFireResistanceLimit;
        private System.Windows.Forms.Label LablefireResistanceLimit;
        private System.Windows.Forms.Label labelLenthElement;
        private System.Windows.Forms.TextBox textBoxLenthElement;
        private System.Windows.Forms.Label labelLenthInmm;
        private System.Windows.Forms.Label labelHeightInmm;
        private System.Windows.Forms.TextBox textBoxHeightElement;
        private System.Windows.Forms.Label labelHeightElement;
        private System.Windows.Forms.Label labelWidthInmm;
        private System.Windows.Forms.TextBox textBoxWidthElement;
        private System.Windows.Forms.Label labelWidthElement;
        private System.Windows.Forms.Label labelFixationElement;
        private System.Windows.Forms.ComboBox comboBoxFixationElement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAInmm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLenth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelArmatureClass;
        private System.Windows.Forms.ComboBox comboBoxArmatureClass;
        private System.Windows.Forms.Label labelConcreteClass;
        private System.Windows.Forms.ComboBox comboBoxConcreteClass;
        private System.Windows.Forms.Label labelArmatureDiameter;
        private System.Windows.Forms.ComboBox comboBoxArmatureDiameter;
        private System.Windows.Forms.Label labelArmatureAmount;
        private System.Windows.Forms.ComboBox comboBoxArmatureAmount;
        private System.Windows.Forms.Label labelMomentSign;
        private System.Windows.Forms.Label labelMomentTxM;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelMoment;
        private System.Windows.Forms.Label labellabelStrengthSign;
        private System.Windows.Forms.Label labelStrengthT;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelConcreteType;
        private System.Windows.Forms.ComboBox comboBoxConcreteType;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonСalculation;
    }
}

