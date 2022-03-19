namespace Ejercicio3_KarenAguilera_LP3
{
    partial class ListaUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Usuario_txt = new System.Windows.Forms.TextBox();
            this.ContraseñaNuevo_Txt = new System.Windows.Forms.TextBox();
            this.ListaUsuarios_dgv = new System.Windows.Forms.DataGridView();
            this.Añadir_btn = new System.Windows.Forms.Button();
            this.Nuevo_btn = new System.Windows.Forms.Button();
            this.Eliminar_btn = new System.Windows.Forms.Button();
            this.Modificar_btn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.Guardar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaUsuarios_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "AÑADIR USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña:";
            // 
            // Usuario_txt
            // 
            this.Usuario_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_txt.Location = new System.Drawing.Point(250, 59);
            this.Usuario_txt.Name = "Usuario_txt";
            this.Usuario_txt.Size = new System.Drawing.Size(195, 26);
            this.Usuario_txt.TabIndex = 4;
            // 
            // ContraseñaNuevo_Txt
            // 
            this.ContraseñaNuevo_Txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaNuevo_Txt.Location = new System.Drawing.Point(250, 110);
            this.ContraseñaNuevo_Txt.Name = "ContraseñaNuevo_Txt";
            this.ContraseñaNuevo_Txt.Size = new System.Drawing.Size(195, 26);
            this.ContraseñaNuevo_Txt.TabIndex = 5;
            // 
            // ListaUsuarios_dgv
            // 
            this.ListaUsuarios_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaUsuarios_dgv.Location = new System.Drawing.Point(24, 250);
            this.ListaUsuarios_dgv.Name = "ListaUsuarios_dgv";
            this.ListaUsuarios_dgv.Size = new System.Drawing.Size(547, 150);
            this.ListaUsuarios_dgv.TabIndex = 6;
            // 
            // Añadir_btn
            // 
            this.Añadir_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Añadir_btn.Location = new System.Drawing.Point(128, 201);
            this.Añadir_btn.Name = "Añadir_btn";
            this.Añadir_btn.Size = new System.Drawing.Size(75, 23);
            this.Añadir_btn.TabIndex = 7;
            this.Añadir_btn.Text = "Añadir Usuario";
            this.Añadir_btn.UseVisualStyleBackColor = true;
            this.Añadir_btn.Click += new System.EventHandler(this.Añadir_btn_Click);
            // 
            // Nuevo_btn
            // 
            this.Nuevo_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo_btn.Location = new System.Drawing.Point(33, 201);
            this.Nuevo_btn.Name = "Nuevo_btn";
            this.Nuevo_btn.Size = new System.Drawing.Size(75, 23);
            this.Nuevo_btn.TabIndex = 8;
            this.Nuevo_btn.Text = "Nuevo";
            this.Nuevo_btn.UseVisualStyleBackColor = true;
            this.Nuevo_btn.Click += new System.EventHandler(this.Nuevo_btn_Click);
            // 
            // Eliminar_btn
            // 
            this.Eliminar_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_btn.Location = new System.Drawing.Point(398, 201);
            this.Eliminar_btn.Name = "Eliminar_btn";
            this.Eliminar_btn.Size = new System.Drawing.Size(75, 23);
            this.Eliminar_btn.TabIndex = 9;
            this.Eliminar_btn.Text = "Eliminar";
            this.Eliminar_btn.UseVisualStyleBackColor = true;
            this.Eliminar_btn.Click += new System.EventHandler(this.Eliminar_btn_Click);
            // 
            // Modificar_btn
            // 
            this.Modificar_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar_btn.Location = new System.Drawing.Point(296, 201);
            this.Modificar_btn.Name = "Modificar_btn";
            this.Modificar_btn.Size = new System.Drawing.Size(86, 23);
            this.Modificar_btn.TabIndex = 10;
            this.Modificar_btn.Text = "Modificar";
            this.Modificar_btn.UseVisualStyleBackColor = true;
            this.Modificar_btn.Click += new System.EventHandler(this.Modificar_btn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar_btn.Location = new System.Drawing.Point(496, 201);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancelar_btn.TabIndex = 11;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // Guardar_btn
            // 
            this.Guardar_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_btn.Location = new System.Drawing.Point(215, 201);
            this.Guardar_btn.Name = "Guardar_btn";
            this.Guardar_btn.Size = new System.Drawing.Size(75, 23);
            this.Guardar_btn.TabIndex = 12;
            this.Guardar_btn.Text = "Guardar";
            this.Guardar_btn.UseVisualStyleBackColor = true;
            // 
            // ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(598, 412);
            this.Controls.Add(this.Guardar_btn);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.Modificar_btn);
            this.Controls.Add(this.Eliminar_btn);
            this.Controls.Add(this.Nuevo_btn);
            this.Controls.Add(this.Añadir_btn);
            this.Controls.Add(this.ListaUsuarios_dgv);
            this.Controls.Add(this.ContraseñaNuevo_Txt);
            this.Controls.Add(this.Usuario_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ListaUsuarios";
            this.Text = "ListaUsuarios";
            this.Load += new System.EventHandler(this.ListaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaUsuarios_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Usuario_txt;
        private System.Windows.Forms.TextBox ContraseñaNuevo_Txt;
        private System.Windows.Forms.DataGridView ListaUsuarios_dgv;
        private System.Windows.Forms.Button Añadir_btn;
        private System.Windows.Forms.Button Nuevo_btn;
        private System.Windows.Forms.Button Eliminar_btn;
        private System.Windows.Forms.Button Modificar_btn;
        private System.Windows.Forms.Button Cancelar_btn;
        private System.Windows.Forms.Button Guardar_btn;
    }
}