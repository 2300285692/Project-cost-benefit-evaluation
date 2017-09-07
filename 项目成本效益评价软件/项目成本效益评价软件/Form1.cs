using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 项目成本效益评价软件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sy.Rows[0].Cells["year"].Value = "第1年";
        }
        //判断内部回报率是否正确
        public int jx(double itxl, double iztz, int tot, ArrayList alr)
        {
            int p = 0;
            double sumjxz = 0;
            double dyearjx = 0;
            for (int i = 0; i < tot - 1; i++)
            {
                double ijxzl = 1;
                for (int j = 0; j < i + 1; j++)
                {
                    ijxzl = (1 + itxl) * ijxzl;
                }
                dyearjx = (int)alr[i] / ijxzl;
                sumjxz = sumjxz + (int)alr[i] / ijxzl;
            }
            sumjxz = sumjxz - iztz;
            if (sumjxz < 0.01 && sumjxz > -0.01)
            { p = 1; }
            else if (sumjxz > 0)
            {
                p = 2;
            }
            else
            {
                p = 3;

            }
            return p;
        }
        public double nb(double iztz,int tot,ArrayList alr)//总投资，年份，每年利润
        {
            double nbhbl = 0 ;//内部贴现率
            double start = 0, end = 1,r=0.5;
            int p;
            bool pan=true;
           
            while (pan)
            {
                p = jx(r, iztz, tot, alr);
                if (p == 1)
                {
                    nbhbl = r;
                    pan = false;
                    break;
                }
                else if (p == 2)
                {
                    start = r;
                }
                else
                {
                    end = r;
                }
                r = (start + end) / 2;
            }
            return nbhbl;
        }
        private void submit_Click(object sender, EventArgs e)
        {
            string strztz = "",strtxl="";
            double iztz;//总投资
            double itxl;//贴现率
            ArrayList alr=new ArrayList();
            strztz = ztz.Text.Trim();
            strtxl = txl.Text.Trim();
            iztz = Convert.ToDouble(strztz);
            itxl = Convert.ToDouble(strtxl);
            //读取表格
            int tot = sy.RowCount;
            string stritem;
            int intitem;
            for (int i = 0; i < tot - 1; i++)
            {
                stritem=sy.Rows[i].Cells["lr"].Value.ToString();
                intitem = Convert.ToInt32(stritem);
                alr.Add(intitem);
            }

            //计算净利润
            double sum=0-iztz;
            for (int i = 0; i < tot - 1; i++)
            {
                sum = sum + (Int32)alr[i];
            }
            jlr.Text =Convert.ToString(sum);
            //计算回收期
            double ihsq=0, sumhsq = 0 - iztz;
            for (int i = 0; i < tot - 1; i++)
            {
                sumhsq = sumhsq + (Int32)alr[i];
                if (sumhsq >= 0)
                {
                    ihsq = i+1;
                    break;
                }
            }
            hsq.Text = Convert.ToString(ihsq);
            
            
            //投资回报率
            double ihbl;
            ihbl = sum * 100 / iztz/tot;
            tzhbl.Text = Convert.ToString(ihbl);
          
            
            //净现值
            double sumjxz= 0 ;
            double dyearjx = 0;
            for (int i = 0; i < tot-1; i++)
            {
                double ijxzl = 1;
                for (int j = 0; j < i+1; j++)
                {
                    ijxzl = (1 + itxl) * ijxzl;
                }
                dyearjx = (int)alr[i] / ijxzl;
                sy.Rows[i].Cells["njxz"].Value = dyearjx;
                sumjxz = sumjxz + (int)alr[i]/ijxzl;
            }
            sumjxz = sumjxz - iztz;
            jxz.Text = Convert.ToString(sumjxz);


            //内部回报率
            double dnbhbl;
            dnbhbl= nb(iztz, tot, alr);
            nbhbl.Text = Convert.ToString(dnbhbl);
        }

        private void sy_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            int tot = sy.RowCount;
            for (int i = 0; i < tot ; i++)
            {
                int year = i + 1;
                sy.Rows[i].Cells["year"].Value = "第" + year + "年";
               
            }
        }


        private void reset_Click(object sender, EventArgs e)
        {
            ztz.Text = "";
            txl.Text = "";
            jlr.Text = "";
            hsq.Text = "";
            tzhbl.Text = "";
            jxz.Text = "";
            nbhbl.Text = "";
            sy.Rows.Clear();
            sy.Rows[0].Cells["year"].Value = "第1年";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
