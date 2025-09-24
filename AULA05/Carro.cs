using System.Reflection.Metadata.Ecma335;

public class Carro
{
    public int Id;
    public string marca;
    public string modelo;
    public string placa;
    public string renavan;
    public string chassi;


    public Carro(string Chassi)
    {
        if (ValidarChassi(Chassi))
        {

            chassi = Chassi;
        }
    }
          

    public   Carro (int id,string Marca,string Modelo,string Placa,string Renavan,string Chassi)
    {
        Id = id;
        marca = Marca;
        modelo = Modelo;    
        placa = Placa;
        renavan = Renavan;
        chassi = Chassi;
    }

    public bool ValidarChassi(string chassi) { 
        chassi = chassi.ToUpper();
     /*
    {
       if(chassi.Length == 17 && !chassi.Contains("O") && !chassi.Contains  ("I") && !chassi.Contains("q"))
        {
            return true;
        }
        throw new Exception("Chassi Invalido!");
     */
     if(chassi.Length != 17)
        {
            throw new Exception("O chassi deve possuir 17 caracteres");
        }else if (chassi.Contains("0"))

        {
            throw new Exception("Chassi não pode possuir a letra O");
        }
        else if (chassi.Contains("I"))


        {
            throw new Exception("Chassi não pode possuir a letra O");
        }
        else if (chassi.Contains("Q"))
        {
            throw new Exception("Chassi não pode possuir a letra O");
        }




        return true;
    }
    



}