namespace WinFormsApp4
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
            dataGridView1 = new DataGridView();
            DisplayAllSt = new Button();
            DisplayAllPr = new Button();
            DisplayAllTy = new Button();
            DisplayAllSup = new Button();
            DisplayMaxQu = new Button();
            DisplayMinQu = new Button();
            DisplayMaxCostPr = new Button();
            DisplayMinCostPr = new Button();
            DisplayAvgQuanByType = new Button();
            DisplayAllInfoOfAPr = new Button();
            DisplayItemsByTy = new Button();
            DisplayItemBySup = new Button();
            DisplayOldestItem = new Button();
            button11 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SupMaxQuan = new Button();
            SupMinQuan = new Button();
            TypeMaxQuan = new Button();
            TypeMinQuan = new Button();
            NumOfDays = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(787, 282);
            dataGridView1.TabIndex = 0;
            // 
            // DisplayAllSt
            // 
            DisplayAllSt.Location = new Point(5, 288);
            DisplayAllSt.Name = "DisplayAllSt";
            DisplayAllSt.Size = new Size(121, 23);
            DisplayAllSt.TabIndex = 1;
            DisplayAllSt.Text = "Весь Склад";
            DisplayAllSt.UseVisualStyleBackColor = true;
            DisplayAllSt.Click += DisplayAllSt_Click;
            // 
            // DisplayAllPr
            // 
            DisplayAllPr.Location = new Point(132, 288);
            DisplayAllPr.Name = "DisplayAllPr";
            DisplayAllPr.Size = new Size(130, 23);
            DisplayAllPr.TabIndex = 2;
            DisplayAllPr.Text = "Всі Продукти";
            DisplayAllPr.UseVisualStyleBackColor = true;
            DisplayAllPr.Click += DisplayAllPr_Click;
            // 
            // DisplayAllTy
            // 
            DisplayAllTy.Location = new Point(267, 288);
            DisplayAllTy.Name = "DisplayAllTy";
            DisplayAllTy.Size = new Size(129, 23);
            DisplayAllTy.TabIndex = 3;
            DisplayAllTy.Text = "Всі Типи";
            DisplayAllTy.UseVisualStyleBackColor = true;
            DisplayAllTy.Click += DisplayAllTy_Click;
            // 
            // DisplayAllSup
            // 
            DisplayAllSup.Location = new Point(5, 317);
            DisplayAllSup.Name = "DisplayAllSup";
            DisplayAllSup.Size = new Size(121, 44);
            DisplayAllSup.TabIndex = 4;
            DisplayAllSup.Text = "Всі Постачальники";
            DisplayAllSup.UseVisualStyleBackColor = true;
            DisplayAllSup.Click += DisplayAllSup_Click;
            // 
            // DisplayMaxQu
            // 
            DisplayMaxQu.Location = new Point(132, 317);
            DisplayMaxQu.Name = "DisplayMaxQu";
            DisplayMaxQu.Size = new Size(130, 44);
            DisplayMaxQu.TabIndex = 5;
            DisplayMaxQu.Text = "Товар з найбільшою кількістю";
            DisplayMaxQu.UseVisualStyleBackColor = true;
            DisplayMaxQu.Click += DisplayMaxQu_Click;
            // 
            // DisplayMinQu
            // 
            DisplayMinQu.Location = new Point(267, 317);
            DisplayMinQu.Name = "DisplayMinQu";
            DisplayMinQu.Size = new Size(129, 44);
            DisplayMinQu.TabIndex = 6;
            DisplayMinQu.Text = "Товар з найменшою кількістю";
            DisplayMinQu.UseVisualStyleBackColor = true;
            DisplayMinQu.Click += DisplayMinQu_Click;
            // 
            // DisplayMaxCostPr
            // 
            DisplayMaxCostPr.Location = new Point(5, 367);
            DisplayMaxCostPr.Name = "DisplayMaxCostPr";
            DisplayMaxCostPr.Size = new Size(87, 71);
            DisplayMaxCostPr.TabIndex = 7;
            DisplayMaxCostPr.Text = "Товар з найбільшою собівіртістю";
            DisplayMaxCostPr.UseVisualStyleBackColor = true;
            DisplayMaxCostPr.Click += DisplayMaxCostPr_Click;
            // 
            // DisplayMinCostPr
            // 
            DisplayMinCostPr.Location = new Point(98, 367);
            DisplayMinCostPr.Name = "DisplayMinCostPr";
            DisplayMinCostPr.Size = new Size(88, 71);
            DisplayMinCostPr.TabIndex = 8;
            DisplayMinCostPr.Text = "Товар з найменшою собівартістю";
            DisplayMinCostPr.UseVisualStyleBackColor = true;
            DisplayMinCostPr.Click += DisplayMinCostPr_Click;
            // 
            // DisplayAvgQuanByType
            // 
            DisplayAvgQuanByType.Location = new Point(192, 367);
            DisplayAvgQuanByType.Name = "DisplayAvgQuanByType";
            DisplayAvgQuanByType.Size = new Size(85, 71);
            DisplayAvgQuanByType.TabIndex = 9;
            DisplayAvgQuanByType.Text = "Середня кількість для кожного типу";
            DisplayAvgQuanByType.UseVisualStyleBackColor = true;
            DisplayAvgQuanByType.Click += DisplayAvgQuanByType_Click;
            // 
            // DisplayAllInfoOfAPr
            // 
            DisplayAllInfoOfAPr.Location = new Point(283, 367);
            DisplayAllInfoOfAPr.Name = "DisplayAllInfoOfAPr";
            DisplayAllInfoOfAPr.Size = new Size(113, 40);
            DisplayAllInfoOfAPr.TabIndex = 10;
            DisplayAllInfoOfAPr.Text = "Вся інформація про товар";
            DisplayAllInfoOfAPr.UseVisualStyleBackColor = true;
            DisplayAllInfoOfAPr.Click += DisplayAllInfoOfAPr_Click;
            // 
            // DisplayItemsByTy
            // 
            DisplayItemsByTy.Location = new Point(283, 413);
            DisplayItemsByTy.Name = "DisplayItemsByTy";
            DisplayItemsByTy.Size = new Size(113, 25);
            DisplayItemsByTy.TabIndex = 11;
            DisplayItemsByTy.Text = "Товари за типом";
            DisplayItemsByTy.UseVisualStyleBackColor = true;
            DisplayItemsByTy.Click += DisplayItemsByTy_Click;
            // 
            // DisplayItemBySup
            // 
            DisplayItemBySup.Location = new Point(500, 288);
            DisplayItemBySup.Name = "DisplayItemBySup";
            DisplayItemBySup.Size = new Size(112, 40);
            DisplayItemBySup.TabIndex = 12;
            DisplayItemBySup.Text = "Товари за постачальником";
            DisplayItemBySup.UseVisualStyleBackColor = true;
            DisplayItemBySup.Click += DisplayItemBySup_Click;
            // 
            // DisplayOldestItem
            // 
            DisplayOldestItem.Location = new Point(402, 288);
            DisplayOldestItem.Name = "DisplayOldestItem";
            DisplayOldestItem.Size = new Size(92, 40);
            DisplayOldestItem.TabIndex = 13;
            DisplayOldestItem.Text = "Найстаріший товар";
            DisplayOldestItem.UseVisualStyleBackColor = true;
            DisplayOldestItem.Click += DisplayOldestItem_Click;
            // 
            // button11
            // 
            button11.Location = new Point(658, 288);
            button11.Name = "button11";
            button11.Size = new Size(130, 23);
            button11.TabIndex = 14;
            button11.Text = "Додати";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button1
            // 
            button1.Location = new Point(658, 317);
            button1.Name = "button1";
            button1.Size = new Size(130, 55);
            button1.TabIndex = 15;
            button1.Text = "Змінити інформацію про товар";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(658, 378);
            button2.Name = "button2";
            button2.Size = new Size(130, 23);
            button2.TabIndex = 16;
            button2.Text = "Змінити типи";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(658, 407);
            button3.Name = "button3";
            button3.Size = new Size(130, 38);
            button3.TabIndex = 17;
            button3.Text = "Змінити постачальників";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(402, 334);
            button4.Name = "button4";
            button4.Size = new Size(103, 23);
            button4.TabIndex = 18;
            button4.Text = "Видалити товар";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(402, 363);
            button5.Name = "button5";
            button5.Size = new Size(103, 23);
            button5.TabIndex = 19;
            button5.Text = "Видалити тип";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(402, 391);
            button6.Name = "button6";
            button6.Size = new Size(103, 47);
            button6.TabIndex = 20;
            button6.Text = "Видалити постачальника";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // SupMaxQuan
            // 
            SupMaxQuan.Location = new Point(5, 444);
            SupMaxQuan.Name = "SupMaxQuan";
            SupMaxQuan.Size = new Size(108, 91);
            SupMaxQuan.TabIndex = 21;
            SupMaxQuan.Text = "Постачальник з максимальною кількістю одного товару";
            SupMaxQuan.UseVisualStyleBackColor = true;
            SupMaxQuan.Click += SupMaxQuan_Click;
            // 
            // SupMinQuan
            // 
            SupMinQuan.Location = new Point(119, 444);
            SupMinQuan.Name = "SupMinQuan";
            SupMinQuan.Size = new Size(114, 91);
            SupMinQuan.TabIndex = 22;
            SupMinQuan.Text = "Постачальник з мінімальною кількістю одного товару";
            SupMinQuan.UseVisualStyleBackColor = true;
            SupMinQuan.Click += SupMinQuan_Click;
            // 
            // TypeMaxQuan
            // 
            TypeMaxQuan.Location = new Point(335, 444);
            TypeMaxQuan.Name = "TypeMaxQuan";
            TypeMaxQuan.Size = new Size(103, 91);
            TypeMaxQuan.TabIndex = 23;
            TypeMaxQuan.Text = "Тип з максимальною кількістю одного товару";
            TypeMaxQuan.UseVisualStyleBackColor = true;
            TypeMaxQuan.Click += TypeMaxQuan_Click;
            // 
            // TypeMinQuan
            // 
            TypeMinQuan.Location = new Point(239, 444);
            TypeMinQuan.Name = "TypeMinQuan";
            TypeMinQuan.Size = new Size(90, 91);
            TypeMinQuan.TabIndex = 24;
            TypeMinQuan.Text = "Тип з мінімальною кількістю одного товару";
            TypeMinQuan.UseVisualStyleBackColor = true;
            TypeMinQuan.Click += TypeMinQuan_Click;
            // 
            // NumOfDays
            // 
            NumOfDays.Location = new Point(444, 444);
            NumOfDays.Name = "NumOfDays";
            NumOfDays.Size = new Size(126, 91);
            NumOfDays.TabIndex = 25;
            NumOfDays.Text = "Товар з часу постачі якого минула задана кількість днів";
            NumOfDays.UseVisualStyleBackColor = true;
            NumOfDays.Click += NumOfDays_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 547);
            Controls.Add(NumOfDays);
            Controls.Add(TypeMinQuan);
            Controls.Add(TypeMaxQuan);
            Controls.Add(SupMinQuan);
            Controls.Add(SupMaxQuan);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button11);
            Controls.Add(DisplayOldestItem);
            Controls.Add(DisplayItemBySup);
            Controls.Add(DisplayItemsByTy);
            Controls.Add(DisplayAllInfoOfAPr);
            Controls.Add(DisplayAvgQuanByType);
            Controls.Add(DisplayMinCostPr);
            Controls.Add(DisplayMaxCostPr);
            Controls.Add(DisplayMinQu);
            Controls.Add(DisplayMaxQu);
            Controls.Add(DisplayAllSup);
            Controls.Add(DisplayAllTy);
            Controls.Add(DisplayAllPr);
            Controls.Add(DisplayAllSt);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridView1;
        private Button DisplayAllSt;
        private Button DisplayAllPr;
        private Button DisplayAllTy;
        private Button DisplayAllSup;
        private Button DisplayMaxQu;
        private Button DisplayMinQu;
        private Button DisplayMaxCostPr;
        private Button DisplayMinCostPr;
        private Button DisplayAvgQuanByType;
        private Button DisplayAllInfoOfAPr;
        private Button DisplayItemsByTy;
        private Button DisplayItemBySup;
        private Button DisplayOldestItem;
        private Button button11;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button SupMaxQuan;
        private Button SupMinQuan;
        private Button TypeMaxQuan;
        private Button TypeMinQuan;
        private Button NumOfDays;
    }
}