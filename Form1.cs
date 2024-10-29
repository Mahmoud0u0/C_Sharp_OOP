using Calculator_1;
using System;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;









namespace Calculator_1
{
    public partial class Form1 : Form
    {

        string ShowNumClick = "";
        char Opr;
        double Number1;
        double Number2;



        public double Claculator(double Num1, double Num2)
        {
            switch (Opr)
            {
                case '+':
                    return Num1 + Num2;

                case '-':
                    return Num1 - Num2;

                case '/':
                    return Num1 / Num2;

                case '*':
                    return Num1 * Num2;

                default:
                    return 0;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void ReadBtn(Button btn)
        {
            ShowNumClick += btn.Tag.ToString();
            txtTotal.Text = ShowNumClick;
        }

        public void ReadBtnOpr(Button btn)
        {
            string Str = btn.Tag.ToString();
            Opr = Str[0];

            txtTotal.Text = Opr.ToString();

            if (!(ShowNumClick == ""))
            {
                Number1 = Convert.ToSingle(ShowNumClick);
            }
            ShowNumClick = "";
        }

        public void Reset()
        {
            txtTotal.Text = "";
            Number1 = 0;
            Number2 = 0;
            ShowNumClick = "";
        }

        public void Equale()
        {
            if (!(ShowNumClick == ""))
            {
                Number2 = Convert.ToSingle(ShowNumClick);
            }
            ShowNumClick = "";
            txtTotal.Text = Claculator(Number1, Number2).ToString();
            Number1 = Claculator(Number1, Number2);
            Number2 = 0;
        }
    

        private void btn_Click(object sender, EventArgs e)
        {
            ReadBtn((Button)sender);
        }

        private void btnOpr_Click(object sender, EventArgs e)
        {
            ReadBtnOpr((Button)sender);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Equale();
        }
    }
}





//class clsCalculator : Form1
//{
//    double _Num1;
//    double _Num2;


//    public double Num1
//    {
//        get { return _Num1; }
//        set { _Num1 = value; }
//    }

//    public double Num2
//    {
//        get { return _Num2; }
//        set { _Num2 = value; }
//    }


//    public void Clear()
//    {
//        _Num1 = 0;
//        _Num2 = 0;
//    }
//}