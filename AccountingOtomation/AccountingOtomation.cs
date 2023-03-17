
using System.Windows.Forms;
using System.Data.OleDb;
using AccountingOtomation.Data;
using System.Data;
using AccountingOtomation.Models;
using System.Collections.Generic;
using System;

namespace AccountingOtomation
{
    public partial class AccountingOtomation : Form
    {
        public AccountingOtomation()
        {
            InitializeComponent();
        }
        private void AccountingOtomation_Load(object sender, EventArgs e)
        {
        }
        string pName = "";
        private List<Period> GettAllPeriodList()
        {
            List<Period> _periodList = new List<Period>();
            List<PeriodPrice> _periodPriceList = new List<PeriodPrice>();
            int PeriodId = 0;
            int PeriodPriceId = 0;
            int k = 0;
            for (int i = 1; i < dgvExcelDocument.ColumnCount - 1; i++)
            {
                if (Convert.ToString(dgvExcelDocument.Rows[0].Cells[i].Value) != "")
                {
                    Period _period = new Period();
                    PeriodId++;
                    _period.PeriodName = Convert.ToString(dgvExcelDocument.Rows[0].Cells[i].Value);
                    _period.PeriodId = PeriodId;
                    _period.PeriodDate = Convert.ToString(dgvExcelDocument.Rows[1].Cells[i].Value);
                    for (int j = 3; j < dgvExcelDocument.RowCount - 1; j++)
                    {
                        if (dgvExcelDocument.Rows[j].Cells[i].Value != null && dgvExcelDocument.Rows[j].Cells[i + 1].Value != null)
                        {
                            
                            PeriodPrice _periodPrice = new PeriodPrice();
                            PeriodPriceId++;
                            _periodPrice.PeriodPriceId = PeriodPriceId;
                            _periodPrice.StartAndStopDate = Convert.ToString(dgvExcelDocument.Rows[j].Cells[0].Value);
                            _periodPrice.USD = Convert.ToString(dgvExcelDocument.Rows[j].Cells[i].Value);
                            _periodPrice.TL = Convert.ToString(dgvExcelDocument.Rows[j].Cells[i + 1].Value);
                            _periodPriceList.Add(_periodPrice);
                        }
                    }
                    _period.PeriodPrice = _periodPriceList;
                    _periodList.Add(_period);
                }
            }
            return _periodList;
        }
        private void ComboBoxGetAllList(List<Period> _periodList)
        {
            List<string> _cbmPeriodList = new List<string>();
            List<string> _cbmDateTimeList = new List<string>();
            foreach (Period _period in _periodList)
            {
                string _periodName = _period.PeriodName;
                if (!_cbmPeriodList.Contains(_periodName))
                {
                    _cbmPeriodList.Add(_periodName);
                }
                foreach (PeriodPrice _periodPrice in _period.PeriodPrice)
                {
                    string _periodStartAndStop = _periodPrice.StartAndStopDate;
                    if (!_cbmDateTimeList.Contains(_periodStartAndStop))
                    {
                        _cbmDateTimeList.Add(_periodStartAndStop);
                    }
                }
            }
            ComboBoxDateTime.DataSource = _cbmDateTimeList;
            ComboBoxPeriod.DataSource = _cbmPeriodList;
        }
        private void txtGetDocument_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Excel Dosyası |*.xlsx";
                file.ShowDialog();
                txtFileExcented.Text = file.FileName;
                ExcelGetALL();
                List<Period> _periodList = GettAllPeriodList();
                ComboBoxGetAllList(_periodList);
            }
            catch (Exception _ex)
            {
                MessageBox.Show(_ex.Message);
            }
        }
        public void ExcelGetALL()
        {
            try
            {
                string baglantiAdresi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtFileExcented.Text + ";Extended Properties='Excel 12.0;IMEX=1;'";

                //bağlantı 
                OleDbConnection baglanti = new OleDbConnection(baglantiAdresi);
                //tüm verileri seçmek için select sorgumuz. Sayfa1 olan kısmı Excel'de hangi sayfayı açmak istiyosanız orayı yazabilirsiniz.
                OleDbCommand komut = new OleDbCommand("Select * From [" + "PERİYOD" + "$]", baglanti);
                //bağlantıyı açıyoruz.
                baglanti.Open();
                //Gelen verileri DataAdapter'e atıyoruz.
                OleDbDataAdapter da = new OleDbDataAdapter(komut);
                //Grid'imiz için bir DataTable oluşturuyoruz.
                DataTable data = new DataTable();
                //DataAdapter'da ki verileri data adındaki DataTable'a dolduruyoruz.
                da.Fill(data);
                dgvExcelDocument.DataSource = data;
            }
            catch (Exception _ex)
            {
                MessageBox.Show(_ex.Message);
            }
        }

        private void btnGetPrice_Click(object sender, EventArgs e)
        {
            try
            {
                String _dateTime = ComboBoxDateTime.SelectedItem.ToString();
                pName = ComboBoxPeriod.SelectedItem.ToString();
                List<Period> _periodList = GettAllPeriodPriceList(_dateTime, pName);
                _periodList = _periodList.FindAll(a => a.PeriodName == pName);
                foreach (Period _perid in _periodList)
                {
                    if (_perid != null)
                    {
                        PeriodPrice _periodPrice = _perid.PeriodPrice.Find(_a => _a.StartAndStopDate == _dateTime);
                        
                        if (_periodPrice.StartAndStopDate == _dateTime)
                        {
                            lblTL.Text = _periodPrice.TL;
                            lblUsd.Text = _periodPrice.USD;
                            //for (int i = 0; i < dgvExcelDocument.RowCount; i++)
                            //{
                            //    dgvPeriodList.Rows[0].Cells[0].Value = _periodPrice.StartAndStopDate;
                            //    if (_periodPrice.USD != "" && _periodPrice.TL != "")
                            //    {
                            //        dgvPeriodList.Rows[0].Cells[1].Value = _periodPrice.USD;
                            //        dgvPeriodList.Rows[i].Cells[2].Value = _periodPrice.TL;
                            //    }
                            //}

                        }

                    }
                }
            }
            catch (Exception _ex)
            {
                MessageBox.Show(_ex.Message);
            }
        }

        private List<Period> GettAllPeriodPriceList(string _date,string _pName)
        {
            try
            {
                List<Period> _periodList = new List<Period>();
                List<PeriodPrice> _periodPriceList = new List<PeriodPrice>();
                int PeriodId = 0;
                int PeriodPriceId = 0;
                for (int i = 1; i < dgvExcelDocument.ColumnCount - 1; i++)
                {
                    if (_pName != "")
                    {
                        Period _period = new Period();
                        PeriodId++;
                        _period.PeriodName = _pName;
                        _period.PeriodId = PeriodId;
                        _period.PeriodDate = _date;
                        for (int j = 3; j < dgvExcelDocument.RowCount - 1; j++)
                        {
                            if (dgvExcelDocument.Rows[j].Cells[i].Value != null && dgvExcelDocument.Rows[j].Cells[i + 1].Value != null)
                            {

                                PeriodPrice _periodPrice = new PeriodPrice();
                                PeriodPriceId++;
                                _periodPrice.PeriodPriceId = PeriodPriceId;
                                _periodPrice.StartAndStopDate = Convert.ToString(dgvExcelDocument.Rows[j].Cells[0].Value);
                                _periodPrice.USD = Convert.ToString(dgvExcelDocument.Rows[j].Cells[i].Value);
                                _periodPrice.TL = Convert.ToString(dgvExcelDocument.Rows[j].Cells[i + 1].Value);
                                _periodPriceList.Add(_periodPrice);
                            }
                        }
                        _period.PeriodPrice = _periodPriceList;
                        _periodList.Add(_period);
                    }
                }
                return _periodList;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
