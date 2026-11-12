namespace WFA_11_12;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        btnHozzaad.Click += BtnHozzaad_Click;
        btnTorol.Click += BtnTorol_Click;
        btnOsszestorlese.Click += BtnOsszestorlese_Click;
    }

    private void BtnTorol_Click(object? sender, EventArgs e)
    {
        lbxLista.Items.Remove(lbxLista.SelectedItem);
        txtSzoveg.Text = string.Empty;
    }

    private void BtnOsszestorlese_Click(object? sender, EventArgs e)
    {
        lbxLista.Items.Clear();
        txtSzoveg.Text = string.Empty;
    }

    private void BtnHozzaad_Click(object? sender, EventArgs e)
    {
        lbxLista.Items.Add(txtSzoveg.Text);
    }
}
