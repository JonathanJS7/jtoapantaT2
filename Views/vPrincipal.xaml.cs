namespace jtoapantaPS2.Views;

public partial class vPrincipal : ContentPage
{
	public vPrincipal()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if (pkEstudiantes.SelectedIndex < 0)
            DisplayAlert("Error", "No hay seleccion de estudiantes", "Ok");

        else
        {
            string datos = pkEstudiantes.Items[pkEstudiantes.SelectedIndex].ToString();

            double notaSeg1 = Convert.ToDouble(txtSeg1.Text);
            double notaExa1 = Convert.ToDouble(txtExa1.Text);

            double promedioParcial1 = (notaSeg1*0.30 + notaExa1*0.20);

            double notaSeg2 = Convert.ToDouble(txtSeg2.Text);
            double notaExa2 = Convert.ToDouble(txtExa2.Text);

            double promedioParcial2 = (notaSeg2*0.30 + notaExa2*0.20);

            double promedioFinal = (promedioParcial1 + promedioParcial2);
            string estado;

            if (promedioFinal >= 7)
            {
                estado = "APROBADO";
            } else if (promedioFinal >= 5 && promedioFinal < 7)
                {
                estado = "COMPLEMENTARIO";
                } else
                    {
                    estado = "REPROBADO";
                    }
            string fecha = dpFecha.Date.ToString("dd/MM/yyyy");

            txtSeg1.Text = "";
            txtExa1.Text = "";
            txtSeg2.Text = "";
            txtExa2.Text = "";
            pkEstudiantes.SelectedIndex = -1;

            DisplayAlert("Estudiante "+datos,
                "La nota final es: " + promedioFinal.ToString("F2") 
                +"\nEstado: " + estado+
                "\nfecha: "+ fecha,
                "\nAceptar");

        }


    }
}