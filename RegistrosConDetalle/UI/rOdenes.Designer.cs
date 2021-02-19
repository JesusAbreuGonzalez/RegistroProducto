
namespace RegistrosConDetalle
{
    partial class rOdenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rOdenes));
            this.OrdenIdLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.ProductoIdLabel = new System.Windows.Forms.Label();
            this.ProductoIdComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DetalleGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductoIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenDetalleIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.DetalleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdenIdLabel
            // 
            this.OrdenIdLabel.AutoSize = true;
            this.OrdenIdLabel.Location = new System.Drawing.Point(20, 29);
            this.OrdenIdLabel.Name = "OrdenIdLabel";
            this.OrdenIdLabel.Size = new System.Drawing.Size(24, 20);
            this.OrdenIdLabel.TabIndex = 0;
            this.OrdenIdLabel.Text = "ID";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(125, 27);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 27);
            this.numericUpDown1.TabIndex = 1;
            // 
            // BuscarButton
            // 
            this.BuscarButton.AutoEllipsis = true;
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(221, 25);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(82, 29);
            this.BuscarButton.TabIndex = 2;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Location = new System.Drawing.Point(20, 79);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(47, 20);
            this.FechaLabel.TabIndex = 3;
            this.FechaLabel.Text = "Fecha";
            // 
            // ProductoIdLabel
            // 
            this.ProductoIdLabel.AutoSize = true;
            this.ProductoIdLabel.Location = new System.Drawing.Point(20, 128);
            this.ProductoIdLabel.Name = "ProductoIdLabel";
            this.ProductoIdLabel.Size = new System.Drawing.Size(88, 20);
            this.ProductoIdLabel.TabIndex = 4;
            this.ProductoIdLabel.Text = "Producto ID";
            // 
            // ProductoIdComboBox
            // 
            this.ProductoIdComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ProductoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductoIdComboBox.FormattingEnabled = true;
            this.ProductoIdComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProductoIdComboBox.Location = new System.Drawing.Point(125, 125);
            this.ProductoIdComboBox.Name = "ProductoIdComboBox";
            this.ProductoIdComboBox.Size = new System.Drawing.Size(178, 28);
            this.ProductoIdComboBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // DetalleGroupBox
            // 
            this.DetalleGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.DetalleGroupBox.Controls.Add(this.RemoverButton);
            this.DetalleGroupBox.Controls.Add(this.AgregarButton);
            this.DetalleGroupBox.Controls.Add(this.dataGridView1);
            this.DetalleGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DetalleGroupBox.Location = new System.Drawing.Point(20, 184);
            this.DetalleGroupBox.Name = "DetalleGroupBox";
            this.DetalleGroupBox.Size = new System.Drawing.Size(567, 294);
            this.DetalleGroupBox.TabIndex = 8;
            this.DetalleGroupBox.TabStop = false;
            this.DetalleGroupBox.Text = "Detalle de orden";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoIdColumn,
            this.OrdenDetalleIdColumn,
            this.OrdenIdColumn,
            this.CantidadColumn});
            this.dataGridView1.Location = new System.Drawing.Point(6, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(551, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // ProductoIdColumn
            // 
            this.ProductoIdColumn.HeaderText = "Producto Id";
            this.ProductoIdColumn.MinimumWidth = 6;
            this.ProductoIdColumn.Name = "ProductoIdColumn";
            this.ProductoIdColumn.Width = 125;
            // 
            // OrdenDetalleIdColumn
            // 
            this.OrdenDetalleIdColumn.HeaderText = "Orden Detalle Id";
            this.OrdenDetalleIdColumn.MinimumWidth = 6;
            this.OrdenDetalleIdColumn.Name = "OrdenDetalleIdColumn";
            this.OrdenDetalleIdColumn.Width = 125;
            // 
            // OrdenIdColumn
            // 
            this.OrdenIdColumn.HeaderText = "Orden Id";
            this.OrdenIdColumn.MinimumWidth = 6;
            this.OrdenIdColumn.Name = "OrdenIdColumn";
            this.OrdenIdColumn.Width = 125;
            // 
            // CantidadColumn
            // 
            this.CantidadColumn.HeaderText = "Cantidad";
            this.CantidadColumn.MinimumWidth = 6;
            this.CantidadColumn.Name = "CantidadColumn";
            this.CantidadColumn.Width = 125;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(467, 18);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(94, 29);
            this.AgregarButton.TabIndex = 9;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            // 
            // RemoverButton
            // 
            this.RemoverButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverButton.Image")));
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(6, 259);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(121, 29);
            this.RemoverButton.TabIndex = 10;
            this.RemoverButton.Text = "Remover Fila";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(110, 504);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(91, 43);
            this.NuevoButton.TabIndex = 9;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(253, 504);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(91, 43);
            this.GuardarButton.TabIndex = 10;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(393, 504);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(91, 43);
            this.EliminarButton.TabIndex = 11;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // rOdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 573);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.DetalleGroupBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ProductoIdComboBox);
            this.Controls.Add(this.ProductoIdLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.OrdenIdLabel);
            this.Name = "rOdenes";
            this.Text = "Registro de Ordenes";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.DetalleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrdenIdLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label ProductoIdLabel;
        private System.Windows.Forms.ComboBox ProductoIdComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox DetalleGroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenDetalleIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadColumn;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
    }
}

