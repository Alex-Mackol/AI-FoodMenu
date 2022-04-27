namespace FoodMenu
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.grBxTypeHuman = new System.Windows.Forms.GroupBox();
            this.radBtnVegan = new System.Windows.Forms.RadioButton();
            this.radBtnVegetar = new System.Windows.Forms.RadioButton();
            this.radBtnMeat = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grBxTypeMeal = new System.Windows.Forms.GroupBox();
            this.radBtnDinner = new System.Windows.Forms.RadioButton();
            this.radBtnLunch = new System.Windows.Forms.RadioButton();
            this.radBtnSnack = new System.Windows.Forms.RadioButton();
            this.radBtnBreakf = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.grBxTypeHuman.SuspendLayout();
            this.grBxTypeMeal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBxTypeHuman
            // 
            this.grBxTypeHuman.BackColor = System.Drawing.Color.Transparent;
            this.grBxTypeHuman.Controls.Add(this.radBtnVegan);
            this.grBxTypeHuman.Controls.Add(this.radBtnVegetar);
            this.grBxTypeHuman.Controls.Add(this.radBtnMeat);
            this.grBxTypeHuman.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grBxTypeHuman.Location = new System.Drawing.Point(80, 133);
            this.grBxTypeHuman.Name = "grBxTypeHuman";
            this.grBxTypeHuman.Size = new System.Drawing.Size(250, 287);
            this.grBxTypeHuman.TabIndex = 0;
            this.grBxTypeHuman.TabStop = false;
            this.grBxTypeHuman.Text = "Хто ви?";
            // 
            // radBtnVegan
            // 
            this.radBtnVegan.AutoSize = true;
            this.radBtnVegan.Location = new System.Drawing.Point(6, 222);
            this.radBtnVegan.Name = "radBtnVegan";
            this.radBtnVegan.Size = new System.Drawing.Size(95, 35);
            this.radBtnVegan.TabIndex = 2;
            this.radBtnVegan.Text = "Веган";
            this.radBtnVegan.UseVisualStyleBackColor = true;
            this.radBtnVegan.CheckedChanged += new System.EventHandler(this.radBtnVegan_CheckedChanged);
            // 
            // radBtnVegetar
            // 
            this.radBtnVegetar.AutoSize = true;
            this.radBtnVegetar.Location = new System.Drawing.Point(6, 138);
            this.radBtnVegetar.Name = "radBtnVegetar";
            this.radBtnVegetar.Size = new System.Drawing.Size(188, 35);
            this.radBtnVegetar.TabIndex = 1;
            this.radBtnVegetar.Text = "Вегетаріанець";
            this.radBtnVegetar.UseVisualStyleBackColor = true;
            this.radBtnVegetar.CheckedChanged += new System.EventHandler(this.radBtnVegetar_CheckedChanged);
            // 
            // radBtnMeat
            // 
            this.radBtnMeat.AutoSize = true;
            this.radBtnMeat.Location = new System.Drawing.Point(6, 54);
            this.radBtnMeat.Name = "radBtnMeat";
            this.radBtnMeat.Size = new System.Drawing.Size(112, 35);
            this.radBtnMeat.TabIndex = 0;
            this.radBtnMeat.Text = "Мясоїд";
            this.radBtnMeat.UseVisualStyleBackColor = true;
            this.radBtnMeat.CheckedChanged += new System.EventHandler(this.radBtnMeat_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 93);
            this.label1.TabIndex = 1;
            this.label1.Text = "Для початку створення рецептів, заповніть анкету меню.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grBxTypeMeal
            // 
            this.grBxTypeMeal.BackColor = System.Drawing.Color.Transparent;
            this.grBxTypeMeal.Controls.Add(this.radBtnDinner);
            this.grBxTypeMeal.Controls.Add(this.radBtnLunch);
            this.grBxTypeMeal.Controls.Add(this.radBtnSnack);
            this.grBxTypeMeal.Controls.Add(this.radBtnBreakf);
            this.grBxTypeMeal.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grBxTypeMeal.Location = new System.Drawing.Point(355, 133);
            this.grBxTypeMeal.Name = "grBxTypeMeal";
            this.grBxTypeMeal.Size = new System.Drawing.Size(260, 287);
            this.grBxTypeMeal.TabIndex = 2;
            this.grBxTypeMeal.TabStop = false;
            this.grBxTypeMeal.Text = "Оберіть прийом їжі:";
            // 
            // radBtnDinner
            // 
            this.radBtnDinner.AutoSize = true;
            this.radBtnDinner.Location = new System.Drawing.Point(24, 164);
            this.radBtnDinner.Name = "radBtnDinner";
            this.radBtnDinner.Size = new System.Drawing.Size(112, 35);
            this.radBtnDinner.TabIndex = 1;
            this.radBtnDinner.TabStop = true;
            this.radBtnDinner.Text = "Вечеря";
            this.radBtnDinner.UseVisualStyleBackColor = true;
            this.radBtnDinner.CheckedChanged += new System.EventHandler(this.radBtnDinner_CheckedChanged);
            // 
            // radBtnLunch
            // 
            this.radBtnLunch.AutoSize = true;
            this.radBtnLunch.Location = new System.Drawing.Point(24, 109);
            this.radBtnLunch.Name = "radBtnLunch";
            this.radBtnLunch.Size = new System.Drawing.Size(85, 35);
            this.radBtnLunch.TabIndex = 0;
            this.radBtnLunch.TabStop = true;
            this.radBtnLunch.Text = "Обід";
            this.radBtnLunch.UseVisualStyleBackColor = true;
            this.radBtnLunch.CheckedChanged += new System.EventHandler(this.radBtnLunch_CheckedChanged);
            // 
            // radBtnSnack
            // 
            this.radBtnSnack.AutoSize = true;
            this.radBtnSnack.Location = new System.Drawing.Point(24, 219);
            this.radBtnSnack.Name = "radBtnSnack";
            this.radBtnSnack.Size = new System.Drawing.Size(125, 35);
            this.radBtnSnack.TabIndex = 0;
            this.radBtnSnack.TabStop = true;
            this.radBtnSnack.Text = "Перекус";
            this.radBtnSnack.UseVisualStyleBackColor = true;
            this.radBtnSnack.CheckedChanged += new System.EventHandler(this.radBtnSnack_CheckedChanged);
            // 
            // radBtnBreakf
            // 
            this.radBtnBreakf.AutoSize = true;
            this.radBtnBreakf.Location = new System.Drawing.Point(24, 54);
            this.radBtnBreakf.Name = "radBtnBreakf";
            this.radBtnBreakf.Size = new System.Drawing.Size(121, 35);
            this.radBtnBreakf.TabIndex = 0;
            this.radBtnBreakf.TabStop = true;
            this.radBtnBreakf.Text = "Завтрак";
            this.radBtnBreakf.UseVisualStyleBackColor = true;
            this.radBtnBreakf.CheckedChanged += new System.EventHandler(this.radBtnBreakf_CheckedChanged);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(205, 434);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(243, 52);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Далі";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 498);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grBxTypeMeal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grBxTypeHuman);
            this.Name = "StartForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.grBxTypeHuman.ResumeLayout(false);
            this.grBxTypeHuman.PerformLayout();
            this.grBxTypeMeal.ResumeLayout(false);
            this.grBxTypeMeal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grBxTypeHuman;
        private RadioButton radBtnVegan;
        private RadioButton radBtnVegetar;
        private RadioButton radBtnMeat;
        private Label label1;
        private GroupBox grBxTypeMeal;
        private RadioButton radBtnDinner;
        private RadioButton radBtnLunch;
        private RadioButton radBtnSnack;
        private RadioButton radBtnBreakf;
        private Button btnNext;
    }
}