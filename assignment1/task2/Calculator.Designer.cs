namespace task2;

partial class Calculator {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
		LeftNum = new TextBox();
		RightNum = new TextBox();
		OpSelector = new ComboBox();
		Equal = new Label();
		ResultDisplayer = new TextBox();
		Calculate = new Button();
		SuspendLayout();
		// 
		// LeftNum
		// 
		LeftNum.Location = new Point(91,46);
		LeftNum.Multiline = true;
		LeftNum.Name = "LeftNum";
		LeftNum.Size = new Size(295,142);
		LeftNum.TabIndex = 0;
		LeftNum.TextChanged += TB_LeftNum;
		// 
		// RightNum
		// 
		RightNum.Location = new Point(537,46);
		RightNum.Multiline = true;
		RightNum.Name = "RightNum";
		RightNum.Size = new Size(310,142);
		RightNum.TabIndex = 1;
		RightNum.TextChanged += TB_RightNum;
		// 
		// OpSelector
		// 
		OpSelector.FormattingEnabled = true;
		OpSelector.Location = new Point(406,101);
		OpSelector.Name = "OpSelector";
		OpSelector.Size = new Size(112,33);
		OpSelector.TabIndex = 2;
		OpSelector.SelectedIndexChanged += Op_Selector;
		// 
		// Equal
		// 
		Equal.AutoSize = true;
		Equal.Font = new Font("Microsoft YaHei UI",18F,FontStyle.Regular,GraphicsUnit.Point,134);
		Equal.Location = new Point(853,88);
		Equal.Name = "Equal";
		Equal.Size = new Size(47,46);
		Equal.TabIndex = 3;
		Equal.Text = "=";
		// 
		// ResultDisplayer
		// 
		ResultDisplayer.Location = new Point(906,46);
		ResultDisplayer.Multiline = true;
		ResultDisplayer.Name = "ResultDisplayer";
		ResultDisplayer.Size = new Size(265,142);
		ResultDisplayer.TabIndex = 4;
		ResultDisplayer.TextChanged += TB_Result;
		// 
		// Calculate
		// 
		Calculate.Location = new Point(861,296);
		Calculate.Name = "Calculate";
		Calculate.Size = new Size(164,99);
		Calculate.TabIndex = 5;
		Calculate.Text = "Calculate";
		Calculate.UseVisualStyleBackColor = true;
		Calculate.Click += Calculate_Click;
		// 
		// Calculator
		// 
		AutoScaleDimensions = new SizeF(11F,25F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1218,935);
		Controls.Add(Calculate);
		Controls.Add(ResultDisplayer);
		Controls.Add(Equal);
		Controls.Add(OpSelector);
		Controls.Add(RightNum);
		Controls.Add(LeftNum);
		Name = "Calculator";
		Text = "Calculator";
		Load += Form_Calculator_Load;
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private TextBox LeftNum;
	private TextBox RightNum;
	private ComboBox OpSelector;
	private Label Equal;
	private TextBox ResultDisplayer;
	private Button Calculate;
}
