import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            ShowWinner(line);
        }
    }
    
    static void ShowWinner(String line){
        String[] str = line.split(" ");
        boolean trump1 = str[0].indexOf(str[3])>0;
        boolean trump2 = str[1].indexOf(str[3])>0;
        if (trump1 && !trump2) System.out.println(str[0]);
        else if (!trump1 && trump2) System.out.println(str[1]);
            else{
                String card1 = str[0].substring(0,str[0].length()-1);
                String card2 = str[1].substring(0,str[1].length()-1);
                if (card1.equals(card2)) System.out.println(str[0] + " " + str[1]);
                else System.out.println(str[biggerCard(card1,card2)]);
            }
    }
    
    static int biggerCard(String card1, String card2){
        if (card1.equals("A"))return 0;
        else if (card2.equals("A")) return 1;
            else if (card1.equals("K")) return 0;
            else if (card2.equals("K")) return 1;
            else if (card1.equals("Q")) return 0;
            else if (card2.equals("Q")) return 1;
            else if (card1.equals("J")) return 0;
            else if (card2.equals("J")) return 1;
            else {
                int num1 = Integer.valueOf(card1);
                int num2 = Integer.valueOf(card2);
                if (num1>num2) return 0;
                    else return 1;
            }
    }
}
