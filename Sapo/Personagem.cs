namespace Sapo;
 
public partial class Personagem
{
    private double Comida;
    private double Agua;
    private double Carinho;
    protected string FotoAnimal;
    
    public Personagem()
    {
        Agua = 0;
        Comida = 0;
        Carinho = 0;
    }

    public void SetComida(double comida)
    {
        if(comida < 0)
            Comida = 0;

        else if( comida > 1)
            Comida = 1;

        else    
            Comida = comida;    
    }

    public void SetAgua(double agua)
    {
        if(agua < 0)
            Agua = 0;
        
        else if(agua > 1)
            Agua = 1;

        else
            Agua = agua; 
    }

    public void SetCarinho(double carinho)
    {
        if(carinho < 0)
            Carinho =  0;

        else if(carinho > 1)
            Carinho = 1;

        else    
            Carinho = carinho; 
    }
    public double GetComida()
    {
        return Comida;
    }
    public double GetAgua()
    {
        return Agua;
    }
    public double GetCarinho()
    {
        return Carinho;
    }

    public string GetImagem()
    {
        return FotoAnimal;
    }



}