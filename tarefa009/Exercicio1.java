import java.util.Scanner;
public class Main{
    
    public static void main(String []args){
        int meses, anos, dias;
        Scanner in = new Scanner( System.in );
        anos = in.nextInt();
        
        meses = in.nextInt();
      
        dias = in.nextInt();
      
      
      dias += (anos * 365) + (meses * 30);
      System.out.println(dias);
    }
}
