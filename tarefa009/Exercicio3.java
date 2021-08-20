import java.util.Scanner;
public class Exercici3{

    public static void main(String []args){
        int saldo = 0;
        
        Scanner in = new Scanner( System.in );
        saldo = in.nextInt();
        
        saldo += (saldo * 0.15);
        
        System.out.println(saldo);
    }
}
