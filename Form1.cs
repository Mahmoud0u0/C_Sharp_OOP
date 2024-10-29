using Calculator_1;
using System;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;



class clsCalculator 
{
    double _Num1;
    double _Num2;
    string _ShowNumClick;
    char _Opr;


    public double Num1
    {
        get { return _Num1; }
        set { _Num1 = value; }
    }

    public double Num2
    {
        get { return _Num2; }
        set { _Num2 = value; }
    }

    public string ShowNumClick
    {
        get { return _ShowNumClick; }
        set { _ShowNumClick = value; }
    }

    public char Opr
    {
        get { return _Opr; }
        set { _Opr = value; }
    }

    public void Clear(TextBox txt)
    {
        _Num1 = 0;
        _Num2 = 0;
        txt.Text = "";
        _ShowNumClick = "";
    }

    public double Claculator(double Num1, double Num2)
    {
        switch (_Opr)
        {
            case '+':
                return Num1 + Num2;

            case '-':
                return Num1 - Num2;

            case '/':
                return Num1 / Num2;

            case '*':
                return Num1 * Num2;

            case '%':
                return Num1 * Num2;

            default:
                return 0;
        }
    }

    public void ReadBtn(Button btn, TextBox txt)
    {
        _ShowNumClick += btn.Tag.ToString();
        txt.Text = _ShowNumClick;
    }

    public void ReadBtnOpr(Button btn, TextBox txt)
    {
        string Str = btn.Tag.ToString();
        _Opr = Str[0];

        txt.Text = _Opr.ToString();

        if (!(_ShowNumClick == ""))
        {
            _Num1 = Convert.ToSingle(_ShowNumClick);
        }
        _ShowNumClick = "";
    }

    public void Equale(TextBox txt)
    {
        if (!(_ShowNumClick == ""))
        {
            _Num2 = Convert.ToSingle(_ShowNumClick);
        }

        _ShowNumClick = "";
        txt.Text = Claculator(_Num1, _Num2).ToString();
        _Num1 = Claculator(_Num1, _Num2);
    }
}





namespace Calculator_1
{
    public partial class Form1 : Form
    {

        clsCalculator Calc = new clsCalculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Calc.ReadBtn((Button)sender, txtTotal);
        }

        private void btnOpr_Click(object sender, EventArgs e)
        {
            Calc.ReadBtnOpr((Button)sender, txtTotal);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Calc.Clear(txtTotal);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Calc.Equale(txtTotal);
        }
    }
}





