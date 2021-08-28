import java.util.Scanner;
public class Exercici6{

    public static void main(String []args){
        int numero = 0;
        System.out.println("Digite um número: ");
        Scanner in = new Scanner( System.in );
        numero = in.nextInt();
        System.out.println("Ant.: " + (numero-1));
        System.out.println("Suc.: " + (numero+1));
    }
}
