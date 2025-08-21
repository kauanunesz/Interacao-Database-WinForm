namespace TesdeBD
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
            dataVG_tela = new DataGridView();
            btn_list = new Button();
            ((System.ComponentModel.ISupportInitialize)dataVG_tela).BeginInit();
            SuspendLayout();
            // 
            // dataVG_tela
            // 
            dataVG_tela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataVG_tela.Location = new Point(146, 95);
            dataVG_tela.Name = "dataVG_tela";
            dataVG_tela.Size = new Size(484, 150);
            dataVG_tela.TabIndex = 0;
            // 
            // btn_list
            // 
            btn_list.Location = new Point(304, 316);
            btn_list.Name = "btn_list";
            btn_list.Size = new Size(164, 56);
            btn_list.TabIndex = 1;
            btn_list.Text = "Listar Dados";
            btn_list.UseVisualStyleBackColor = true;
            btn_list.Click += btn_list_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_list);
            Controls.Add(dataVG_tela);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataVG_tela).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataVG_tela;
        private Button btn_list;
    }
}
