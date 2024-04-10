namespace Sapo;

public partial class MainPage : ContentPage
{
	Cabrito cabrito; 
	Capivara capivara;
	Raposa raposa;
	Personagem atual;
	public MainPage()
	{
		InitializeComponent();

		cabrito= new Cabrito();
		capivara= new Capivara();
		raposa= new Raposa();

		atual = cabrito;
		
	}

	private void ClicouBotaoComida( object sender, EventArgs args)
	{ 
		atual.SetComida(atual.GetComida()+0.1);
		progressBarComida.Progress=atual.GetComida();

	}
	private void ClicouBotaoAgua(object sender, EventArgs args)
	{ 
		atual.SetAgua(atual.GetAgua()+0.1);
		progressBarAgua.Progress=atual.GetAgua();

	}
	private void ClicouBotaoCarinho(object sender, EventArgs args)
	{ 
		atual.SetCarinho(atual.GetCarinho()+0.1);
		progressCarinho.Progress=atual.GetCarinho();

	}

	private void ClicouSetaDireita(object sender, EventArgs args)
	{
		if(atual == cabrito)
			atual = capivara;
		
		else if(atual == capivara)
			atual = raposa;

		else if(atual == raposa)
			atual = cabrito;

		ImagemAnimal.Source = atual.GetImagem();
	}
}

