import java.util.Scanner;
import java.lang.Math;
public class Exercici5{

    public static void main(String []args){
        float salario = 0;
        float salarioMin = 0;
        int quantSalario = 0;
        
        
        Scanner in = new Scanner( System.in );
        salarioMin = in.nextFloat();

        salario = in.nextFloat();
        
        quantSalario = (int)(salario/salarioMin);
        System.out.println(quantSalario+"SM=" + (quantSalario*salarioMin));
    }
}
