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

            double promedioParcial1 = (notaSeg1 + notaExa1) * 0.5;

            double notaSeg2 = Convert.ToDouble(txtSeg2.Text);
            double notaExa2 = Convert.ToDouble(txtExa2.Text);

            double promedioParcial2 = (notaSeg2 + notaExa2) * 0.5;

            double promedioFinal = (promedioParcial1 + promedioParcial2) / 2;

            DisplayAlert("Estudiante"+datos, "La nota final es: " + promedioFinal.ToString(), "Aceptar");


        }

        string fecha = dpFecha.Date.ToString();
        DisplayAlert("ALERTA", "La fecha seleccionada es: " + fecha, "Ok");
    }
}