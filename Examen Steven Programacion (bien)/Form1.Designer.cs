namespace Examen_Steven_Programacion__bien_
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
            btnInsertar_Click = new Button();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // btnInsertar_Click
            // 
            btnInsertar_Click.Location = new Point(664, 335);
            btnInsertar_Click.Name = "btnInsertar_Click";
            btnInsertar_Click.Size = new Size(75, 23);
            btnInsertar_Click.TabIndex = 0;
            btnInsertar_Click.Text = "Insertar";
            btnInsertar_Click.UseVisualStyleBackColor = true;
            btnInsertar_Click.Click += btnInsertar_Click_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 151);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Identificador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(566, 151);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre ";
            // 
            // txtId
            // 
            txtId.Location = new Point(105, 185);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(520, 185);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInsertar_Click);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertar_Click;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNombre;
    }
}