namespace task2;

public partial class Calculator:Form {
	public Calculator() {
		InitializeComponent();
	}

	private void Form_Calculator_Load(object sender, EventArgs e) {
		OpSelector.Items.Add("+");
		OpSelector.Items.Add("-");
		OpSelector.Items.Add("*");
		OpSelector.Items.Add("/");
		OpSelector.SelectedIndex = 0;
	}

	private void TB_RightNum(object sender, EventArgs e) {

	}

	private void TB_LeftNum(object sender, EventArgs e) {

	}

	private void Op_Selector(object sender, EventArgs e) {

	}

	private void TB_Result(object sender, EventArgs e) {

	}

	private void Calculate_Click(object sender, EventArgs e) {
		double leftNum, rightNum, result = 0;
		string op = OpSelector.SelectedItem.ToString();

		bool isLeftNum = double.TryParse(LeftNum.Text, out leftNum);
		bool isRightNum = double.TryParse(RightNum.Text, out rightNum);

		if (!isLeftNum || !isRightNum) {
			ResultDisplayer.Text = "Please input legal number!";
			return;
		}
		switch (op) {
			case "+":
				result = leftNum + rightNum;
				break;
			case "-":
				result = leftNum - rightNum;
				break;
			case "*":
				result = leftNum * rightNum;
				break;
			case "/":
				if (rightNum == 0) {
					ResultDisplayer.Text = "The divisor can't be zero!";
					return;
				}
				result = leftNum / rightNum;
				break;
		}
		ResultDisplayer.Text = result.ToString();
	}
}
