namespace Laboratorio_PichardoGonzalez
{
    partial class Reporte_Ventas
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
            this.tableLayout_Form = new System.Windows.Forms.TableLayoutPanel();
            this.design_LabelUp = new System.Windows.Forms.Label();
            this.tableLayout_DownOptions = new System.Windows.Forms.TableLayoutPanel();
            this.LabelDesde = new System.Windows.Forms.Label();
            this.LabelTipoPago = new System.Windows.Forms.Label();
            this.tableLayout_Codigo = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.LabelHasta = new System.Windows.Forms.Label();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.tableLayout_Seguro = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxSeguro = new System.Windows.Forms.CheckBox();
            this.checkBoxCliente = new System.Windows.Forms.CheckBox();
            this.LabelFormato = new System.Windows.Forms.Label();
            this.tableLayout_Botones = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Generar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtoneExcel = new System.Windows.Forms.RadioButton();
            this.radioButtonPDF = new System.Windows.Forms.RadioButton();
            this.tableLayout_Form.SuspendLayout();
            this.tableLayout_DownOptions.SuspendLayout();
            this.tableLayout_Codigo.SuspendLayout();
            this.tableLayout_Seguro.SuspendLayout();
            this.tableLayout_Botones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout_Form
            // 
            this.tableLayout_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout_Form.BackColor = System.Drawing.Color.Transparent;
            this.tableLayout_Form.ColumnCount = 1;
            this.tableLayout_Form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Form.Controls.Add(this.design_LabelUp, 0, 0);
            this.tableLayout_Form.Controls.Add(this.tableLayout_DownOptions, 0, 1);
            this.tableLayout_Form.Location = new System.Drawing.Point(-1, -1);
            this.tableLayout_Form.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayout_Form.Name = "tableLayout_Form";
            this.tableLayout_Form.RowCount = 2;
            this.tableLayout_Form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayout_Form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayout_Form.Size = new System.Drawing.Size(605, 278);
            this.tableLayout_Form.TabIndex = 2;
            this.tableLayout_Form.Click += new System.EventHandler(this.Reporte_Ventas_Click);
            // 
            // design_LabelUp
            // 
            this.design_LabelUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.design_LabelUp.AutoSize = true;
            this.design_LabelUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.design_LabelUp.Location = new System.Drawing.Point(20, 0);
            this.design_LabelUp.Margin = new System.Windows.Forms.Padding(20, 0, 4, 0);
            this.design_LabelUp.Name = "design_LabelUp";
            this.design_LabelUp.Size = new System.Drawing.Size(581, 27);
            this.design_LabelUp.TabIndex = 0;
            this.design_LabelUp.Text = "REPORTE DE VENTAS";
            this.design_LabelUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayout_DownOptions
            // 
            this.tableLayout_DownOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout_DownOptions.ColumnCount = 3;
            this.tableLayout_DownOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayout_DownOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayout_DownOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayout_DownOptions.Controls.Add(this.LabelDesde, 0, 1);
            this.tableLayout_DownOptions.Controls.Add(this.LabelTipoPago, 0, 2);
            this.tableLayout_DownOptions.Controls.Add(this.tableLayout_Codigo, 1, 1);
            this.tableLayout_DownOptions.Controls.Add(this.tableLayout_Seguro, 1, 2);
            this.tableLayout_DownOptions.Controls.Add(this.LabelFormato, 0, 3);
            this.tableLayout_DownOptions.Controls.Add(this.tableLayout_Botones, 1, 4);
            this.tableLayout_DownOptions.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tableLayout_DownOptions.Location = new System.Drawing.Point(0, 27);
            this.tableLayout_DownOptions.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout_DownOptions.Name = "tableLayout_DownOptions";
            this.tableLayout_DownOptions.RowCount = 6;
            this.tableLayout_DownOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayout_DownOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayout_DownOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayout_DownOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayout_DownOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayout_DownOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayout_DownOptions.Size = new System.Drawing.Size(605, 251);
            this.tableLayout_DownOptions.TabIndex = 1;
            this.tableLayout_DownOptions.Click += new System.EventHandler(this.Reporte_Ventas_Click);
            // 
            // LabelDesde
            // 
            this.LabelDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDesde.AutoSize = true;
            this.LabelDesde.Location = new System.Drawing.Point(0, 25);
            this.LabelDesde.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDesde.Name = "LabelDesde";
            this.LabelDesde.Size = new System.Drawing.Size(181, 30);
            this.LabelDesde.TabIndex = 0;
            this.LabelDesde.Text = "DESDE:";
            this.LabelDesde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelDesde.Click += new System.EventHandler(this.Reporte_Ventas_Click);
            // 
            // LabelTipoPago
            // 
            this.LabelTipoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTipoPago.AutoSize = true;
            this.LabelTipoPago.Location = new System.Drawing.Point(0, 55);
            this.LabelTipoPago.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTipoPago.Name = "LabelTipoPago";
            this.LabelTipoPago.Size = new System.Drawing.Size(181, 30);
            this.LabelTipoPago.TabIndex = 1;
            this.LabelTipoPago.Text = "TIPO DE PAGO:";
            this.LabelTipoPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelTipoPago.Click += new System.EventHandler(this.Reporte_Ventas_Click);
            // 
            // tableLayout_Codigo
            // 
            this.tableLayout_Codigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout_Codigo.ColumnCount = 4;
            this.tableLayout_Codigo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayout_Codigo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayout_Codigo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayout_Codigo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout_Codigo.Controls.Add(this.dateTimeHasta, 2, 0);
            this.tableLayout_Codigo.Controls.Add(this.LabelHasta, 1, 0);
            this.tableLayout_Codigo.Controls.Add(this.dateTimeDesde, 0, 0);
            this.tableLayout_Codigo.Location = new System.Drawing.Point(181, 25);
            this.tableLayout_Codigo.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout_Codigo.Name = "tableLayout_Codigo";
            this.tableLayout_Codigo.RowCount = 1;
            this.tableLayout_Codigo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Codigo.Size = new System.Drawing.Size(363, 30);
            this.tableLayout_Codigo.TabIndex = 3;
            this.tableLayout_Codigo.Click += new System.EventHandler(this.Reporte_Ventas_Click);
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeHasta.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeHasta.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(162, 0);
            this.dateTimeHasta.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(108, 27);
            this.dateTimeHasta.TabIndex = 10;
            // 
            // LabelHasta
            // 
            this.LabelHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHasta.AutoSize = true;
            this.LabelHasta.Location = new System.Drawing.Point(108, 0);
            this.LabelHasta.Margin = new System.Windows.Forms.Padding(0);
            this.LabelHasta.Name = "LabelHasta";
            this.LabelHasta.Size = new System.Drawing.Size(54, 30);
            this.LabelHasta.TabIndex = 9;
            this.LabelHasta.Text = "HASTA:";
            this.LabelHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDesde.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDesde.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDesde.Location = new System.Drawing.Point(0, 0);
            this.dateTimeDesde.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(108, 27);
            this.dateTimeDesde.TabIndex = 7;
            // 
            // tableLayout_Seguro
            // 
            this.tableLayout_Seguro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout_Seguro.ColumnCount = 3;
            this.tableLayout_Seguro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout_Seguro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout_Seguro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout_Seguro.Controls.Add(this.checkBoxSeguro, 0, 0);
            this.tableLayout_Seguro.Controls.Add(this.checkBoxCliente, 0, 0);
            this.tableLayout_Seguro.Location = new System.Drawing.Point(181, 55);
            this.tableLayout_Seguro.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout_Seguro.Name = "tableLayout_Seguro";
            this.tableLayout_Seguro.RowCount = 1;
            this.tableLayout_Seguro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Seguro.Size = new System.Drawing.Size(363, 30);
            this.tableLayout_Seguro.TabIndex = 5;
            this.tableLayout_Seguro.Click += new System.EventHandler(this.Reporte_Ventas_Click);
            // 
            // checkBoxSeguro
            // 
            this.checkBoxSeguro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSeguro.AutoSize = true;
            this.checkBoxSeguro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSeguro.Location = new System.Drawing.Point(90, 0);
            this.checkBoxSeguro.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSeguro.Name = "checkBoxSeguro";
            this.checkBoxSeguro.Size = new System.Drawing.Size(90, 30);
            this.checkBoxSeguro.TabIndex = 1;
            this.checkBoxSeguro.Text = "SEGURO";
            this.checkBoxSeguro.UseVisualStyleBackColor = true;
            // 
            // checkBoxCliente
            // 
            this.checkBoxCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCliente.AutoSize = true;
            this.checkBoxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCliente.Location = new System.Drawing.Point(0, 0);
            this.checkBoxCliente.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxCliente.Name = "checkBoxCliente";
            this.checkBoxCliente.Size = new System.Drawing.Size(90, 30);
            this.checkBoxCliente.TabIndex = 0;
            this.checkBoxCliente.Text = "CLIENTE";
            this.checkBoxCliente.UseVisualStyleBackColor = true;
            // 
            // LabelFormato
            // 
            this.LabelFormato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFormato.AutoSize = true;
            this.LabelFormato.Location = new System.Drawing.Point(0, 85);
            this.LabelFormato.Margin = new System.Windows.Forms.Padding(0);
            this.LabelFormato.Name = "LabelFormato";
            this.LabelFormato.Size = new System.Drawing.Size(181, 30);
            this.LabelFormato.TabIndex = 8;
            this.LabelFormato.Text = "FORMATO:";
            this.LabelFormato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelFormato.Click += new System.EventHandler(this.Reporte_Ventas_Click);
            // 
            // tableLayout_Botones
            // 
            this.tableLayout_Botones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout_Botones.ColumnCount = 3;
            this.tableLayout_Botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayout_Botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayout_Botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout_Botones.Controls.Add(this.Btn_Generar, 1, 0);
            this.tableLayout_Botones.Location = new System.Drawing.Point(181, 115);
            this.tableLayout_Botones.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayout_Botones.Name = "tableLayout_Botones";
            this.tableLayout_Botones.RowCount = 1;
            this.tableLayout_Botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout_Botones.Size = new System.Drawing.Size(363, 30);
            this.tableLayout_Botones.TabIndex = 6;
            this.tableLayout_Botones.Click += new System.EventHandler(this.Reporte_Ventas_Click);
            // 
            // Btn_Generar
            // 
            this.Btn_Generar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Generar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Generar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Btn_Generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Generar.Location = new System.Drawing.Point(108, 3);
            this.Btn_Generar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Btn_Generar.Name = "Btn_Generar";
            this.Btn_Generar.Size = new System.Drawing.Size(163, 27);
            this.Btn_Generar.TabIndex = 4;
            this.Btn_Generar.Text = "GENERAR";
            this.Btn_Generar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.radioButtoneExcel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonPDF, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(181, 85);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 30);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.Reporte_Ventas_Click);
            // 
            // radioButtoneExcel
            // 
            this.radioButtoneExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtoneExcel.AutoSize = true;
            this.radioButtoneExcel.Location = new System.Drawing.Point(0, 0);
            this.radioButtoneExcel.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtoneExcel.Name = "radioButtoneExcel";
            this.radioButtoneExcel.Size = new System.Drawing.Size(90, 30);
            this.radioButtoneExcel.TabIndex = 1;
            this.radioButtoneExcel.TabStop = true;
            this.radioButtoneExcel.Text = "EXCEL";
            this.radioButtoneExcel.UseVisualStyleBackColor = true;
            // 
            // radioButtonPDF
            // 
            this.radioButtonPDF.AutoSize = true;
            this.radioButtonPDF.Location = new System.Drawing.Point(93, 3);
            this.radioButtonPDF.Name = "radioButtonPDF";
            this.radioButtonPDF.Size = new System.Drawing.Size(57, 20);
            this.radioButtonPDF.TabIndex = 0;
            this.radioButtonPDF.TabStop = true;
            this.radioButtonPDF.Text = "PDF";
            this.radioButtonPDF.UseVisualStyleBackColor = true;
            // 
            // Reporte_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 273);
            this.Controls.Add(this.tableLayout_Form);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reporte_Ventas";
            this.ShowIcon = false;
            this.Text = ".:. Reporte de ventas .:.";
            this.Load += new System.EventHandler(this.Reporte_Ventas_Load);
            this.Click += new System.EventHandler(this.Reporte_Ventas_Click);
            this.tableLayout_Form.ResumeLayout(false);
            this.tableLayout_Form.PerformLayout();
            this.tableLayout_DownOptions.ResumeLayout(false);
            this.tableLayout_DownOptions.PerformLayout();
            this.tableLayout_Codigo.ResumeLayout(false);
            this.tableLayout_Codigo.PerformLayout();
            this.tableLayout_Seguro.ResumeLayout(false);
            this.tableLayout_Seguro.PerformLayout();
            this.tableLayout_Botones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout_Form;
        private System.Windows.Forms.Label design_LabelUp;
        private System.Windows.Forms.TableLayoutPanel tableLayout_DownOptions;
        private System.Windows.Forms.Label LabelDesde;
        private System.Windows.Forms.Label LabelTipoPago;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Codigo;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Seguro;
        private System.Windows.Forms.TableLayoutPanel tableLayout_Botones;
        private System.Windows.Forms.Button Btn_Generar;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.Label LabelFormato;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.Label LabelHasta;
        private System.Windows.Forms.CheckBox checkBoxCliente;
        private System.Windows.Forms.CheckBox checkBoxSeguro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtoneExcel;
        private System.Windows.Forms.RadioButton radioButtonPDF;
    }
}