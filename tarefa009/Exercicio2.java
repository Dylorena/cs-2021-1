public class Exercicio2{

     public static void main(String []args){
         int[] grupo1 = {8, 9, 7};
         int[] grupo2 = {4, 5, 6};
         float media1 = 0;
         float media2 = 0;
         
         for(int i = 0; i < grupo1.length; i++){
            media1 += grupo1[i];
         }
         
         for(int i = 0; i < grupo2.length; i++){
            media2 += grupo2[i];
         }
         
        media1 = media1/3;
        System.out.println("média aritmética dos números 8,9 e 7: " + media1);
        
        media2 = media2/3;
        System.out.println("média dos números 4, 5 e 6: " + media2);

        float somaTotal = media2 + media1;
        System.out.println("soma das duas médias: " + somaTotal);
        
        System.out.println("média das médias: " + somaTotal/2);
     }
}
