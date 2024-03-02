using System.Drawing;

namespace ElecticityApp
{
    partial class Form1
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
            this.btnElectro = new System.Windows.Forms.Button();
            this.btnZadachi = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnElectro
            // 
            this.btnElectro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnElectro.FlatAppearance.BorderSize = 0;
            this.btnElectro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElectro.ForeColor = System.Drawing.Color.White;
            this.btnElectro.Location = new System.Drawing.Point(12, 30);
            this.btnElectro.Name = "btnElectro";
            this.btnElectro.Size = new System.Drawing.Size(266, 50);
            this.btnElectro.TabIndex = 0;
            this.btnElectro.Text = "Электростатика";
            this.btnElectro.UseVisualStyleBackColor = false;
            this.btnElectro.MouseLeave += new System.EventHandler(this.btnElectro_MouseLeave);
            this.btnElectro.MouseHover += new System.EventHandler(this.btnElcetro_MouseHover);
            // 
            // btnZadachi
            // 
            this.btnZadachi.FlatAppearance.BorderSize = 0;
            this.btnZadachi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZadachi.ForeColor = System.Drawing.Color.White;
            this.btnZadachi.Location = new System.Drawing.Point(12, 90);
            this.btnZadachi.Name = "btnZadachi";
            this.btnZadachi.Size = new System.Drawing.Size(266, 50);
            this.btnZadachi.TabIndex = 1;
            this.btnZadachi.Text = "Задачи";
            this.btnZadachi.UseVisualStyleBackColor = true;
            this.btnZadachi.MouseLeave += new System.EventHandler(this.btnZadachi_MouseLeave);
            this.btnZadachi.MouseHover += new System.EventHandler(this.btnZadachi_MouseHover);
            // 
            // btnCalc
            // 
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(12, 150);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(266, 50);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Калькулятор";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.MouseLeave += new System.EventHandler(this.btnCalc_MouseLeave);
            this.btnCalc.MouseHover += new System.EventHandler(this.btnCalc_MouseHover);
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnElectro);
            this.splitContainer.Panel1.Controls.Add(this.btnCalc);
            this.splitContainer.Panel1.Controls.Add(this.btnZadachi);
            this.splitContainer.Panel1MinSize = 350;
            this.splitContainer.Panel2MinSize = 500;
            this.splitContainer.Size = new System.Drawing.Size(914, 778);
            this.splitContainer.SplitterDistance = 350;
            this.splitContainer.SplitterWidth = 18;
            this.splitContainer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(914, 778);
            this.Controls.Add(this.splitContainer);
            this.Name = "Form1";
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button btnElectro;
        private System.Windows.Forms.Button btnZadachi;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}

