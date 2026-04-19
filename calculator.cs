namespace WinFormsApp1 
{ 
 public partial class Form1 : Form 
 { 
  public Form1() 
  { 
   InitializeComponent(); 
  } 
  private void addbtn_Click(object sender, EventArgs e) 
  { 
result.Text = (Convert.ToInt32(value1.Text) + 
Convert.ToInt32(value2.Text)).ToString();                                                                                                                             
} 
 
  private void subbtn_Click(object sender, EventArgs e) 
  { 
result.Text = (Convert.ToInt32(value1.Text) - 
Convert.ToInt32(value2.Text)).ToString(); 
  }                                                                       
  private void divbtn_Click(object sender, EventArgs e) 
  { 
result.Text = (Convert.ToInt32(value1.Text) / 
Convert.ToInt32(value2.Text)).ToString(); 
  } 
  private void mulbtn_Click(object sender, EventArgs e) 
  { 
result.Text = (Convert.ToInt32(value1.Text) * 
Convert.ToInt32(value2.Text)).ToString(); 
  } 
 } 
}
