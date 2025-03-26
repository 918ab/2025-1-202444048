using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03Proj01
{
    //class 구성 요소 : 값 + 기능
    public partial class Form1: Form
    {  
        //멤버변수, 인스턴스변수
        //C# : 인스턴스 필드 (field)
        TextBox[] arrTbxData = new TextBox[5];

        //생성자
        //1. 이름은 Class 이름과 통일해야함
        //2. 반환타입 없음
        //3. 인스턴스 생성시 무조건 1번만 호출됨
        public Form1()
        {
            InitializeComponent();
            arrTbxData = new TextBox[5];
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;
        }
        
        private void btnProcess01_Click(object sender, EventArgs e)
        {
            //배열의 가장 큰 특징 : 고정길이
            //배열 생성시 사용할 길이(Length) 정해놓고 시작
            //arrTbxData = new TextBox[5];
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

            //배열의 길이는 반드시 상수 (변하지 않는) 값이 들어가야 한다
            //배열의 길이는 생성 변하지 않기 때문에
            //다른 배열의 길이로 사용해도 괜찮다
            //struct 는 struct의 기본값 (int는 0)
            //class 는 null이 기본값
            //int[] arrIntData = new int[5];
            int[] arrIntData = new int[arrTbxData.Length];
            for (int i = 0; i < arrTbxData.Length; i++) {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text)){
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                } else{
                    //arrIntData[i] = 0; 과 동일함
                }
            }
            int result = 0;
            if (rbtAdd.Checked){
                for (int i = 0; i < arrIntData.Length; i++){
                    result += arrIntData[i];
                }
            } else if (rbtSub.Checked){
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++){
                    result -= arrIntData[i];
                }
            } else if (rbtMul.Checked){
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++){
                    result *= arrIntData[i];
                }
            } else if (rbtDiv.Checked){
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++){
                    if (arrIntData[i] == 0){
                        arrTbxData[i].Focus();
                        MessageBox.Show("0 XXXXXX");
                        return;
                    }
                    result /= arrIntData[i];
                }
            } else {
                MessageBox.Show("연산을 선택하세요");
                return;
            }
            lblResult.Text = result.ToString();
        }

        private void btnProcess03_Click(object sender, EventArgs e)
        {
            //Array vs. List
            //고정길이   가변길이
            //Length    Count
            //  String a = "11";
            //  int b = a.Length;
            //  a += "b"; -> "11b"
            //  b = a.Length;

            
            //TextBox[] arrTbxData = new TextBox[5];
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

            //Generic (일반화) 지원 자료형
            List<int> arrIntData = new List<int>();
            for (int i = 0; i < arrTbxData.Length; i++)
            {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text))
                {
                    //Add() 추가, Insert() 삽입, Remove() 내용지움, RemoveAt() 위치지움
                    arrIntData.Add(int.Parse(arrTbxData[i].Text));
                } else
                {
                    //arrIntData[i] = 0; 과 동일함
                }
            }
            int result = 0;
            if (rbtAdd.Checked)
            {
                for (int i = 0; i < arrIntData.Count; i++)
                {
                    result += arrIntData[i];
                }
            } else if (rbtSub.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    result -= arrIntData[i];
                }
            } else if (rbtMul.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    result *= arrIntData[i];
                }
            } else if (rbtDiv.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    if (arrIntData[i] == 0)
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0 XXXXXX");
                        return;
                    }
                    result /= arrIntData[i];
                }
            } else
            {
                MessageBox.Show("연산을 선택하세요");
                return;
            }
            lblResult.Text = result.ToString();
        }

        private void btnProcess04_Click(object sender, EventArgs e)
        {
            //TextBox[] arrTbxData = new TextBox[5];
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;
            List<int> arrIntData = new List<int>();
            for (int i = 0; i < arrTbxData.Length; i++)
            {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text))
                {
                    arrIntData.Add(int.Parse(arrTbxData[i].Text));
                } 
            }
            int result = 0;
            String totalResult = "";
            if(!chkAdd.Checked && !chkSub.Checked && !chkMul.Checked && !chkDiv.Checked)
            {
                MessageBox.Show("연산을 선택하세요");
                return;
            }
            if (chkAdd.Checked)
            {
                
                for (int i = 0; i < arrIntData.Count; i++)
                {
                    result += arrIntData[i];
                }
                totalResult += $"더하기 : {result}";
                totalResult += Environment.NewLine;
            }if (chkSub.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    result -= arrIntData[i];
                }
                totalResult += $"빼기 : {result}";
                totalResult += Environment.NewLine;
            }
            if (chkMul.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    result *= arrIntData[i];
                }
                totalResult += $"곱하기 : {result}";
                totalResult += Environment.NewLine;
            }
            if (chkDiv.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    if (arrIntData[i] == 0)
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0 XXXXXX");
                        return;
                    }
                    result /= arrIntData[i];
                }
                totalResult += $"나누기 : {result}";
                totalResult += Environment.NewLine;

            }
            lblResult.Text = totalResult.ToString();
        }

        private void chkOption_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton[] radioButtons = new RadioButton[] { rbtAdd, rbtDiv, rbtMul, rbtSub };
            List<CheckBox> checkBoxes = new List<CheckBox> { chkAdd,chkDiv,chkMul,chkSub };

            var isEng = chkOption.Checked;
            string word;

            for (int i = 0; i < radioButtons.Length; i++){
                switch (i){
                    case 0:
                        word = isEng ? "Add" : "더하기";
                        break;
                    case 1:
                        word = isEng ? "Div" : "나누기";
                        break;
                    case 2:
                        word = isEng ? "Mul" : "곱하기";
                        break;
                    case 3:
                        word = isEng ? "Sub" : "빼기";
                        break;
                    default:
                        continue;
                }
                radioButtons[i].Text = word;
                checkBoxes[i].Text = word;
            }
            for (int i = 0; i < checkBoxes.Count; i++)
            {

            }

        }

        private void btnProcess06_Click(object sender, EventArgs e)
        {
            //Combox 미선택시 SelectedIndex == -1
            if (cmbBeverage.SelectedIndex < 0){
                MessageBox.Show("음료를 선택하세요");
                return;
            }
            int price = 0;
            switch (cmbBeverage.SelectedItem.ToString())
            {
                case "아메리카노": price = 2500; break;
                case "카페라떼": price = 3000; break;
                case "플랫화이트": price = 3800; break;
                default:return;
            }
            var iceoption = chkIce.Checked ? "아이스" : "";
            var iceprice = chkIce.Checked ? 500 : 0;

            lblResult.Text = $"{iceoption} {cmbBeverage.SelectedItem} : " + $"{price + iceprice}";
            
        }

        private void btnProcess07_Click(object sender, EventArgs e)
        {
            if (cmbBeverage.SelectedIndex < 0)
            {
                MessageBox.Show("음료를 선택하세요");
                return;
            }
            int price = 0;
            switch (cmbBeverage.SelectedIndex)
            {
                case 0: price = 2500; break;
                case 1: price = 3000; break;
                case 2: price = 3800; break;
                default: return;
            }
            var iceoption = chkIce.Checked ? "아이스" : "";
            var iceprice = chkIce.Checked ? 500 : 0;

            lblResult.Text = $"{iceoption} {cmbBeverage.SelectedItem} : " + $"{price + iceprice}";
        }

        private void btnProcess08_Click(object sender, EventArgs e)
        {
            if (cmbBeverage.SelectedIndex < 0)
            {
                MessageBox.Show("음료를 선택하세요");
                return;
            }

            var prices = new int[] { 2500, 3500, 3800 };
            int price = 0;
            if (cmbBeverage.SelectedIndex < prices.Length){
                price = prices[cmbBeverage.SelectedIndex];
            } else
            {
                return;
            }
                var iceoption = chkIce.Checked ? "아이스" : "";
            var iceprice = chkIce.Checked ? 500 : 0;

            lblResult.Text = $"{iceoption} {cmbBeverage.SelectedItem} : " + $"{price + iceprice}";
        }
    }
}
