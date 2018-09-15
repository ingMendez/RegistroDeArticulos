namespace Registros_articulos.UI.Registros
{
    partial class rArticulos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rArticulos));
            this.Buscar_button = new System.Windows.Forms.Button();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CantidadCotizada_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Existencia_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Precio_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Descripcion_textBox = new System.Windows.Forms.TextBox();
            this.FechaVencimiento_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ArticuloId_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuperErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadCotizada_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Existencia_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloId_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Buscar_button
            // 
            this.Buscar_button.Image = ((System.Drawing.Image)(resources.GetObject("Buscar_button.Image")));
            this.Buscar_button.Location = new System.Drawing.Point(243, 58);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(60, 66);
            this.Buscar_button.TabIndex = 31;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar_button.Image")));
            this.Eliminar_button.Location = new System.Drawing.Point(228, 317);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(57, 54);
            this.Eliminar_button.TabIndex = 30;
            this.Eliminar_button.Text = "Eliminar";
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // Guardar_button
            // 
            this.Guardar_button.Image = ((System.Drawing.Image)(resources.GetObject("Guardar_button.Image")));
            this.Guardar_button.Location = new System.Drawing.Point(129, 317);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(54, 54);
            this.Guardar_button.TabIndex = 29;
            this.Guardar_button.Text = "Guardar";
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo_button.Image")));
            this.Nuevo_button.Location = new System.Drawing.Point(27, 317);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(52, 54);
            this.Nuevo_button.TabIndex = 28;
            this.Nuevo_button.Text = "Nuevo";
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Cantidad Cotizada";
            // 
            // CantidadCotizada_numericUpDown
            // 
            this.CantidadCotizada_numericUpDown.Location = new System.Drawing.Point(129, 282);
            this.CantidadCotizada_numericUpDown.Name = "CantidadCotizada_numericUpDown";
            this.CantidadCotizada_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CantidadCotizada_numericUpDown.TabIndex = 26;
            // 
            // Existencia_numericUpDown
            // 
            this.Existencia_numericUpDown.Location = new System.Drawing.Point(129, 251);
            this.Existencia_numericUpDown.Name = "Existencia_numericUpDown";
            this.Existencia_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Existencia_numericUpDown.TabIndex = 25;
            // 
            // Precio_numericUpDown
            // 
            this.Precio_numericUpDown.Location = new System.Drawing.Point(129, 220);
            this.Precio_numericUpDown.Name = "Precio_numericUpDown";
            this.Precio_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Precio_numericUpDown.TabIndex = 24;
            // 
            // Descripcion_textBox
            // 
            this.Descripcion_textBox.Location = new System.Drawing.Point(129, 161);
            this.Descripcion_textBox.Multiline = true;
            this.Descripcion_textBox.Name = "Descripcion_textBox";
            this.Descripcion_textBox.Size = new System.Drawing.Size(199, 53);
            this.Descripcion_textBox.TabIndex = 23;
            // 
            // FechaVencimiento_dateTimePicker
            // 
            this.FechaVencimiento_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaVencimiento_dateTimePicker.Location = new System.Drawing.Point(129, 127);
            this.FechaVencimiento_dateTimePicker.Name = "FechaVencimiento_dateTimePicker";
            this.FechaVencimiento_dateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.FechaVencimiento_dateTimePicker.TabIndex = 22;
            // 
            // ArticuloId_numericUpDown
            // 
            this.ArticuloId_numericUpDown.Location = new System.Drawing.Point(129, 81);
            this.ArticuloId_numericUpDown.Name = "ArticuloId_numericUpDown";
            this.ArticuloId_numericUpDown.Size = new System.Drawing.Size(85, 20);
            this.ArticuloId_numericUpDown.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Existencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha Vencimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Articulo Id";
            // 
            // SuperErrorProvider
            // 
            this.SuperErrorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Descripcion_textBox);
            this.panel1.Controls.Add(this.Buscar_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Eliminar_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Guardar_button);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Nuevo_button);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CantidadCotizada_numericUpDown);
            this.panel1.Controls.Add(this.ArticuloId_numericUpDown);
            this.panel1.Controls.Add(this.Existencia_numericUpDown);
            this.panel1.Controls.Add(this.FechaVencimiento_dateTimePicker);
            this.panel1.Controls.Add(this.Precio_numericUpDown);
            this.panel1.Location = new System.Drawing.Point(9, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 393);
            this.panel1.TabIndex = 32;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // rArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 391);
            this.Controls.Add(this.panel1);
            this.Name = "rArticulos";
            this.Text = "rArticulos";
            ((System.ComponentModel.ISupportInitialize)(this.CantidadCotizada_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Existencia_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precio_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloId_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown CantidadCotizada_numericUpDown;
        private System.Windows.Forms.NumericUpDown Existencia_numericUpDown;
        private System.Windows.Forms.NumericUpDown Precio_numericUpDown;
        private System.Windows.Forms.TextBox Descripcion_textBox;
        private System.Windows.Forms.DateTimePicker FechaVencimiento_dateTimePicker;
        private System.Windows.Forms.NumericUpDown ArticuloId_numericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider SuperErrorProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}