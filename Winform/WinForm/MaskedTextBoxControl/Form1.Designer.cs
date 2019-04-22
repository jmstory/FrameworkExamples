using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MaskedTextBoxControl
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(34, 36);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(138, 21);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(34, 82);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(137, 21);
            this.maskedTextBox2.TabIndex = 1;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox2.TypeValidationCompleted += new TypeValidationEventHandler(maskedTextBox2_TypeValidationCompleted);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DoMaskBinding()
        {
            try
            {
                sc = new SqlConnection("Data Source=CLIENTUE;Initial Catalog=NORTHWIND;Integrated Security=SSPI");
                sc.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            dataConnect = new SqlDataAdapter("SELECT * FROM Employees", sc);
            dataConnect.Fill(employeesTable, "Employees");

            try
            {
                currentBinding = new Binding("Text", employeesTable, "Employees.FirstName");
                //firstName.DataBindings.Add(currentBinding);

                currentBinding = new Binding("Text", employeesTable, "Employees.LastName");
                //lastName.DataBindings.Add(currentBinding);
                phoneBinding = new Binding("Text", employeesTable, "Employees.HomePhone");
               
                phoneBinding.Format += new ConvertEventHandler(phoneBinding_Format);
                phoneBinding.Parse += new ConvertEventHandler(phoneBinding_Parse);
                //phoneMask.DataBindings.Add(phoneBinding);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void phoneBinding_Format(Object sender, ConvertEventArgs e)
        {
            String ext;

            DataRowView currentRow = (DataRowView)BindingContext[employeesTable, "Employees"].Current;
            if (currentRow["Extension"] == null)
            {
                ext = "";
            }
            else
            {
                ext = currentRow["Extension"].ToString();
            }

            e.Value = e.Value.ToString().Trim() + " x" + ext;
        }

        private void phoneBinding_Parse(Object sender, ConvertEventArgs e)
        {
            String phoneNumberAndExt = e.Value.ToString();

            int extIndex = phoneNumberAndExt.IndexOf("x");
            String ext = phoneNumberAndExt.Substring(extIndex).Trim();
            String phoneNumber = phoneNumberAndExt.Substring(0, extIndex).Trim();
           
            DataRowView currentRow = (DataRowView)BindingContext[employeesTable, "Employees"].Current;
            
            currentRow["Extension"] = ext.Substring(1);
           
            e.Value = phoneNumber;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            BindingContext[employeesTable, "Employees"].Position = BindingContext[employeesTable, "Employees"].Position - 1;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            BindingContext[employeesTable, "Employees"].Position = BindingContext[employeesTable, "Employees"].Position + 1;
        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;

        Binding currentBinding, phoneBinding;
        DataSet employeesTable = new DataSet();
        SqlConnection sc;
        SqlDataAdapter dataConnect;
    }
}

