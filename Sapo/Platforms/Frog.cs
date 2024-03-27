namespace  Sapo

public class Frog 
{
private int fome; 
protected int sede;
public int tristeza;


public Frog ( )
{ 
   fome=0;
   sede=0;
   tristeza=0;
}


public void SetFome (int f)
{ 
if ( f <=1 || f>=0)
    fome=f;
else if (f > 1)
    fome= 1;
else 
    fome= 0;
}

public int Getfome( )
{ 
  return  fome;


  }  


}