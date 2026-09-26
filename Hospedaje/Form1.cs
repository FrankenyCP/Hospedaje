namespace Hospedaje
{
    public partial class frmcotizador : Form
    {
        public frmcotizador()
        {
            InitializeComponent();
        }

        private void btnimperactivo_Click(object sender, EventArgs e)
        {
            string Huesped = txthuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txttarifanoche.Text);

            decimal subtotal = noches * tarifa;
            decimal descuento = 0m;
            if (noches >= 7)
            {


                descuento = subtotal * 0.10m;

            }

            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = baseImponible + itbis + servicio;


            lstresultados.Items.Add($"[Imperactivo] {Huesped} : US$ {total: N2}");

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lstresultados.Items.Clear();
            
        }
    }
}

