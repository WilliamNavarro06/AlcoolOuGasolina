double CalcularRazao(double precoEtanol, double precoGasolina){
    return (precoEtanol / precoGasolina);
}

bool DeveUsarGasolina(double razao){
    return razao > 0.73;
}

void Combustivel(double precoEtanol,double precoGasolina){

    double razao = CalcularRazao(precoEtanol, precoGasolina);
    Console.WriteLine($"O preço do etanol corresponde a {razao:F1}% do preço da gasolina");

    if(DeveUsarGasolina(razao)){
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("GASOLINA");
        Console.ResetColor();
    }
    else{
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("ETANOL");
        Console.ResetColor();
    }
}

void Executar(){
    Console.WriteLine("Etanol ou Gasolina");

    Console.WriteLine("Digite o preço do etanol: ");
    double precoEtanol = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o preço do gasolina: ");
    double precoGasonlina = Convert.ToDouble(Console.ReadLine());

    Combustivel(precoEtanol, precoGasonlina);
}

Executar();


