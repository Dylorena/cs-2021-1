import java.util.Scanner;
public class Main{
    
    public static class Peca {

    public int codigo, quant;
    public double vlUnitario;

    public Peca(int codigo, int quant, double vlUnitario) {
        this.codigo = codigo;
        this.quant = quant;
        this.vlUnitario = vlUnitario;
    }

  }
    static Peca p1 = new Peca(1, 3, 3.99);
    static Peca p2 = new Peca(2, 10, 2.00);
    
    public static void main(String []args){
      int IPI = 0;
      double total = 0;
      
      Scanner in = new Scanner( System.in );
      IPI = in.nextInt();
      
      total = (p1.vlUnitario * p1.quant + p2.vlUnitario * p2.quant) * (IPI/100.00 + 1);
      System.out.println(total);
    }
}
