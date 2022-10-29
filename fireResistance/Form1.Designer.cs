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
            this.textBoxLenthFromArmatureToEdge = new System.Windows.Forms.TextBox();
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
            this.textBoxMoment = new System.Windows.Forms.TextBox();
            this.labelMoment = new System.Windows.Forms.Label();
            this.labellabelStrengthSign = new System.Windows.Forms.Label();
            this.labelStrengthT = new System.Windows.Forms.Label();
            this.textBoxStrength = new System.Windows.Forms.TextBox();
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
            this.comboBoxFireResistanceLimit.Location = new System.Drawing.Point(31, 40);
            this.comboBoxFireResistanceLimit.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFireResistanceLimit.Name = "comboBoxFireResistanceLimit";
            this.comboBoxFireResistanceLimit.Size = new System.Drawing.Size(80, 24);
            this.comboBoxFireResistanceLimit.TabIndex = 0;
            this.comboBoxFireResistanceLimit.Text = "R120";
            this.comboBoxFireResistanceLimit.SelectedIndexChanged += new System.EventHandler(this.comboBoxFireResistanceLimit_SelectedIndexChanged);
            // 
            // LablefireResistanceLimit
            // 
            this.LablefireResistanceLimit.AutoSize = true;
            this.LablefireResistanceLimit.Location = new System.Drawing.Point(14, 21);
            this.LablefireResistanceLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LablefireResistanceLimit.Name = "LablefireResistanceLimit";
            this.LablefireResistanceLimit.Size = new System.Drawing.Size(299, 16);
            this.LablefireResistanceLimit.TabIndex = 1;
            this.LablefireResistanceLimit.Text = "Выберете требуемый предел огнестойкости";
            // 
            // labelLenthElement
            // 
            this.labelLenthElement.AutoSize = true;
            this.labelLenthElement.Location = new System.Drawing.Point(12, 68);
            this.labelLenthElement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLenthElement.Name = "labelLenthElement";
            this.labelLenthElement.Size = new System.Drawing.Size(173, 16);
            this.labelLenthElement.TabIndex = 2;
            this.labelLenthElement.Text = "Укажите длину элемента";
            // 
            // textBoxLenthElement
            // 
            this.textBoxLenthElement.Location = new System.Drawing.Point(60, 86);
            this.textBoxLenthElement.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLenthElement.Name = "textBoxLenthElement";
            this.textBoxLenthElement.Size = new System.Drawing.Size(100, 22);
            this.textBoxLenthElement.TabIndex = 3;
            this.textBoxLenthElement.TextChanged += new System.EventHandler(this.textBoxLenthElement_TextChanged);
            // 
            // labelLenthInmm
            // 
            this.labelLenthInmm.AutoSize = true;
            this.labelLenthInmm.Location = new System.Drawing.Point(170, 94);
            this.labelLenthInmm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.labelHeightInmm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeightInmm.Name = "labelHeightInmm";
            this.labelHeightInmm.Size = new System.Drawing.Size(25, 16);
            this.labelHeightInmm.TabIndex = 7;
            this.labelHeightInmm.Text = "мм";
            this.labelHeightInmm.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxHeightElement
            // 
            this.textBoxHeightElement.Location = new System.Drawing.Point(60, 135);
            this.textBoxHeightElement.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHeightElement.Name = "textBoxHeightElement";
            this.textBoxHeightElement.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeightElement.TabIndex = 6;
            this.textBoxHeightElement.TextChanged += new System.EventHandler(this.textBoxHeightElement_TextChanged);
            // 
            // labelHeightElement
            // 
            this.labelHeightElement.AutoSize = true;
            this.labelHeightElement.Location = new System.Drawing.Point(15, 114);
            this.labelHeightElement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.labelWidthInmm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWidthInmm.Name = "labelWidthInmm";
            this.labelWidthInmm.Size = new System.Drawing.Size(25, 16);
            this.labelWidthInmm.TabIndex = 10;
            this.labelWidthInmm.Text = "мм";
            // 
            // textBoxWidthElement
            // 
            this.textBoxWidthElement.Location = new System.Drawing.Point(60, 179);
            this.textBoxWidthElement.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWidthElement.Name = "textBoxWidthElement";
            this.textBoxWidthElement.Size = new System.Drawing.Size(100, 22);
            this.textBoxWidthElement.TabIndex = 9;
            this.textBoxWidthElement.TextChanged += new System.EventHandler(this.textBoxWidthElement_TextChanged);
            // 
            // labelWidthElement
            // 
            this.labelWidthElement.AutoSize = true;
            this.labelWidthElement.Location = new System.Drawing.Point(16, 159);
            this.labelWidthElement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWidthElement.Name = "labelWidthElement";
            this.labelWidthElement.Size = new System.Drawing.Size(182, 16);
            this.labelWidthElement.TabIndex = 8;
            this.labelWidthElement.Text = "Укажите ширину элемента";
            // 
            // labelFixationElement
            // 
            this.labelFixationElement.AutoSize = true;
            this.labelFixationElement.Location = new System.Drawing.Point(18, 248);
            this.labelFixationElement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFixationElement.Name = "labelFixationElement";
            this.labelFixationElement.Size = new System.Drawing.Size(356, 16);
            this.labelFixationElement.TabIndex = 12;
            this.labelFixationElement.Text = "Выберите вариант закрепления по концам элемента";
            // 
            // comboBoxFixationElement
            // 
            this.comboBoxFixationElement.FormattingEnabled = true;
            this.comboBoxFixationElement.Items.AddRange(new object[] {
            "НЕ СМЕЩАЕМАЯ ЗАДЕЛКА НА ДВУХ КОНЦАХ",
            "НЕ СМЕЩАЕМАЯ ЗАДЕЛКА НА ДВУХ КОНЦАХ С ПОДАТЛИВЫМ ОГРАНИЧЕННЫМ ПОВОРОТОМ",
            "ШАРНИРНЫЕ ОПОРЫ НА ДВУХ КОНЦАХ"});
            this.comboBoxFixationElement.Location = new System.Drawing.Point(31, 268);
            this.comboBoxFixationElement.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFixationElement.Name = "comboBoxFixationElement";
            this.comboBoxFixationElement.Size = new System.Drawing.Size(636, 24);
            this.comboBoxFixationElement.TabIndex = 11;
            this.comboBoxFixationElement.Text = "НЕ СМЕЩАЕМАЯ ЗАДЕЛКА НА ДВУХ КОНЦАХ С ПОДАТЛИВЫМ ОГРАНИЧЕННЫМ ПОВОРОТОМ";
            this.comboBoxFixationElement.SelectedIndexChanged += new System.EventHandler(this.comboBoxFixationElement_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(488, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // labelAInmm
            // 
            this.labelAInmm.AutoSize = true;
            this.labelAInmm.Location = new System.Drawing.Point(170, 230);
            this.labelAInmm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAInmm.Name = "labelAInmm";
            this.labelAInmm.Size = new System.Drawing.Size(25, 16);
            this.labelAInmm.TabIndex = 16;
            this.labelAInmm.Text = "мм";
            // 
            // textBoxLenthFromArmatureToEdge
            // 
            this.textBoxLenthFromArmatureToEdge.Location = new System.Drawing.Point(60, 222);
            this.textBoxLenthFromArmatureToEdge.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLenthFromArmatureToEdge.Name = "textBoxLenthFromArmatureToEdge";
            this.textBoxLenthFromArmatureToEdge.Size = new System.Drawing.Size(100, 22);
            this.textBoxLenthFromArmatureToEdge.TabIndex = 15;
            this.textBoxLenthFromArmatureToEdge.TextChanged += new System.EventHandler(this.textBoxLenthFromArmatureToEdge_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Укажите расстояние от грани элемента до центра тяжести арматуры";
            // 
            // labelLenth
            // 
            this.labelLenth.AutoSize = true;
            this.labelLenth.Location = new System.Drawing.Point(31, 92);
            this.labelLenth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLenth.Name = "labelLenth";
            this.labelLenth.Size = new System.Drawing.Size(24, 16);
            this.labelLenth.TabIndex = 17;
            this.labelLenth.Text = "L =";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(31, 141);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(24, 16);
            this.labelHeight.TabIndex = 18;
            this.labelHeight.Text = "h =";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(31, 185);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(25, 16);
            this.labelWidth.TabIndex = 19;
            this.labelWidth.Text = "b =";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(31, 229);
            this.labelA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(25, 16);
            this.labelA.TabIndex = 20;
            this.labelA.Text = "a =";
            // 
            // labelArmatureClass
            // 
            this.labelArmatureClass.AutoSize = true;
            this.labelArmatureClass.Location = new System.Drawing.Point(18, 294);
            this.labelArmatureClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            "А500С МАРКА 25Г2С ПО ГОСТ Р 52544-2006",
            "А600С МАРКИ 18Г2СФ ТЕРМОМЕХАНИЧЕСКИ УПРОЧНЕННАЯ",
            "А500С МАРКИ Ст3Гпс ТЕРМОМЕХАНИЧЕСКИ УПРОЧНЕННАЯ ПО ГОСТ 34028-2016"});
            this.comboBoxArmatureClass.Location = new System.Drawing.Point(31, 312);
            this.comboBoxArmatureClass.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxArmatureClass.Name = "comboBoxArmatureClass";
            this.comboBoxArmatureClass.Size = new System.Drawing.Size(636, 24);
            this.comboBoxArmatureClass.TabIndex = 21;
            this.comboBoxArmatureClass.Text = "А500С МАРКИ Ст3Гпс ТЕРМОМЕХАНИЧЕСКИ УПРОЧНЕННАЯ ПО ГОСТ 34028-2016";
            this.comboBoxArmatureClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxArmatureClass_SelectedIndexChanged);
            // 
            // labelConcreteClass
            // 
            this.labelConcreteClass.AutoSize = true;
            this.labelConcreteClass.Location = new System.Drawing.Point(18, 386);
            this.labelConcreteClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.comboBoxConcreteClass.Location = new System.Drawing.Point(31, 405);
            this.comboBoxConcreteClass.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxConcreteClass.Name = "comboBoxConcreteClass";
            this.comboBoxConcreteClass.Size = new System.Drawing.Size(80, 24);
            this.comboBoxConcreteClass.TabIndex = 23;
            this.comboBoxConcreteClass.Text = "B30";
            this.comboBoxConcreteClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxConcreteClass_SelectedIndexChanged_1);
            // 
            // labelArmatureDiameter
            // 
            this.labelArmatureDiameter.AutoSize = true;
            this.labelArmatureDiameter.Location = new System.Drawing.Point(18, 432);
            this.labelArmatureDiameter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.comboBoxArmatureDiameter.Location = new System.Drawing.Point(31, 451);
            this.comboBoxArmatureDiameter.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxArmatureDiameter.Name = "comboBoxArmatureDiameter";
            this.comboBoxArmatureDiameter.Size = new System.Drawing.Size(80, 24);
            this.comboBoxArmatureDiameter.TabIndex = 25;
            this.comboBoxArmatureDiameter.Text = "10";
            this.comboBoxArmatureDiameter.SelectedIndexChanged += new System.EventHandler(this.comboBoxArmatureDiameter_SelectedIndexChanged);
            // 
            // labelArmatureAmount
            // 
            this.labelArmatureAmount.AutoSize = true;
            this.labelArmatureAmount.Location = new System.Drawing.Point(18, 478);
            this.labelArmatureAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.comboBoxArmatureAmount.Location = new System.Drawing.Point(31, 498);
            this.comboBoxArmatureAmount.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxArmatureAmount.Name = "comboBoxArmatureAmount";
            this.comboBoxArmatureAmount.Size = new System.Drawing.Size(80, 24);
            this.comboBoxArmatureAmount.TabIndex = 27;
            this.comboBoxArmatureAmount.Text = "2";
            this.comboBoxArmatureAmount.SelectedIndexChanged += new System.EventHandler(this.comboBoxArmatureAmount_SelectedIndexChanged);
            // 
            // labelMomentSign
            // 
            this.labelMomentSign.AutoSize = true;
            this.labelMomentSign.Location = new System.Drawing.Point(31, 550);
            this.labelMomentSign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMomentSign.Name = "labelMomentSign";
            this.labelMomentSign.Size = new System.Drawing.Size(28, 16);
            this.labelMomentSign.TabIndex = 32;
            this.labelMomentSign.Text = "M =";
            // 
            // labelMomentTxM
            // 
            this.labelMomentTxM.AutoSize = true;
            this.labelMomentTxM.Location = new System.Drawing.Point(175, 552);
            this.labelMomentTxM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMomentTxM.Name = "labelMomentTxM";
            this.labelMomentTxM.Size = new System.Drawing.Size(28, 16);
            this.labelMomentTxM.TabIndex = 31;
            this.labelMomentTxM.Text = "т*м";
            // 
            // textBoxMoment
            // 
            this.textBoxMoment.Location = new System.Drawing.Point(64, 542);
            this.textBoxMoment.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMoment.Name = "textBoxMoment";
            this.textBoxMoment.Size = new System.Drawing.Size(100, 22);
            this.textBoxMoment.TabIndex = 30;
            this.textBoxMoment.TextChanged += new System.EventHandler(this.textBoxMoment_TextChanged);
            // 
            // labelMoment
            // 
            this.labelMoment.AutoSize = true;
            this.labelMoment.Location = new System.Drawing.Point(18, 524);
            this.labelMoment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoment.Name = "labelMoment";
            this.labelMoment.Size = new System.Drawing.Size(625, 16);
            this.labelMoment.TabIndex = 29;
            this.labelMoment.Text = "Укажите величину изгибающего момента от постоянной и длительной нормативной нагру" +
    "зки";
            // 
            // labellabelStrengthSign
            // 
            this.labellabelStrengthSign.AutoSize = true;
            this.labellabelStrengthSign.Location = new System.Drawing.Point(31, 596);
            this.labellabelStrengthSign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labellabelStrengthSign.Name = "labellabelStrengthSign";
            this.labellabelStrengthSign.Size = new System.Drawing.Size(27, 16);
            this.labellabelStrengthSign.TabIndex = 36;
            this.labellabelStrengthSign.Text = "N =";
            this.labellabelStrengthSign.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labelStrengthT
            // 
            this.labelStrengthT.AutoSize = true;
            this.labelStrengthT.Location = new System.Drawing.Point(176, 599);
            this.labelStrengthT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStrengthT.Name = "labelStrengthT";
            this.labelStrengthT.Size = new System.Drawing.Size(14, 16);
            this.labelStrengthT.TabIndex = 35;
            this.labelStrengthT.Text = "т";
            this.labelStrengthT.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // textBoxStrength
            // 
            this.textBoxStrength.Location = new System.Drawing.Point(64, 589);
            this.textBoxStrength.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStrength.Name = "textBoxStrength";
            this.textBoxStrength.Size = new System.Drawing.Size(100, 22);
            this.textBoxStrength.TabIndex = 34;
            this.textBoxStrength.TextChanged += new System.EventHandler(this.textBoxStrength_TextChanged);
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Location = new System.Drawing.Point(18, 569);
            this.labelStrength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(593, 16);
            this.labelStrength.TabIndex = 33;
            this.labelStrength.Text = "Укажите величину нормальной силы от постоянной и длительной нормативной нагрузки";
            this.labelStrength.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelConcreteType
            // 
            this.labelConcreteType.AutoSize = true;
            this.labelConcreteType.Location = new System.Drawing.Point(18, 340);
            this.labelConcreteType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConcreteType.Name = "labelConcreteType";
            this.labelConcreteType.Size = new System.Drawing.Size(149, 16);
            this.labelConcreteType.TabIndex = 38;
            this.labelConcreteType.Text = "Выберите вид бетона";
            // 
            // comboBoxConcreteType
            // 
            this.comboBoxConcreteType.FormattingEnabled = true;
            this.comboBoxConcreteType.Items.AddRange(new object[] {
            "ТЯЖЕЛЫЙ, НА СИЛИКАТНОМ ЗАПОЛНИТЕЛЕ",
            "ТЯЖЕЛЫЙ, НА КАРБОНАТНОМ ЗАПОЛНИТЕЛЕ",
            "КОНСТРУКЦИОННЫЙ КЕРАМЗИТОБЕТОН"});
            this.comboBoxConcreteType.Location = new System.Drawing.Point(31, 360);
            this.comboBoxConcreteType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxConcreteType.Name = "comboBoxConcreteType";
            this.comboBoxConcreteType.Size = new System.Drawing.Size(636, 24);
            this.comboBoxConcreteType.TabIndex = 37;
            this.comboBoxConcreteType.Text = "ТЯЖЕЛЫЙ, НА СИЛИКАТНОМ ЗАПОЛНИТЕЛЕ";
            this.comboBoxConcreteType.SelectedIndexChanged += new System.EventHandler(this.comboBoxConcreteType_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(546, 614);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
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
            this.buttonСalculation.Location = new System.Drawing.Point(340, 614);
            this.buttonСalculation.Margin = new System.Windows.Forms.Padding(2);
            this.buttonСalculation.Name = "buttonСalculation";
            this.buttonСalculation.Size = new System.Drawing.Size(200, 30);
            this.buttonСalculation.TabIndex = 40;
            this.buttonСalculation.Text = "Расчет";
            this.buttonСalculation.UseVisualStyleBackColor = true;
            this.buttonСalculation.Click += new System.EventHandler(this.buttonСalculation_Click);
            // 
            // LableFireResistanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(680, 658);
            this.Controls.Add(this.buttonСalculation);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelConcreteType);
            this.Controls.Add(this.comboBoxConcreteType);
            this.Controls.Add(this.labellabelStrengthSign);
            this.Controls.Add(this.labelStrengthT);
            this.Controls.Add(this.textBoxStrength);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.labelMomentSign);
            this.Controls.Add(this.labelMomentTxM);
            this.Controls.Add(this.textBoxMoment);
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
            this.Controls.Add(this.textBoxLenthFromArmatureToEdge);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LableFireResistanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox textBoxLenthFromArmatureToEdge;
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
        private System.Windows.Forms.TextBox textBoxMoment;
        private System.Windows.Forms.Label labelMoment;
        private System.Windows.Forms.Label labellabelStrengthSign;
        private System.Windows.Forms.Label labelStrengthT;
        private System.Windows.Forms.TextBox textBoxStrength;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelConcreteType;
        private System.Windows.Forms.ComboBox comboBoxConcreteType;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonСalculation;
    }
}

