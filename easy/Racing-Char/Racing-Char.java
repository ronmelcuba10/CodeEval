import java.io.*;
public class Main {
    public static void main (String[] args) throws IOException {
        File file = new File(args[0]);
        BufferedReader buffer = new BufferedReader(new FileReader(file));
        String line;
        int posAnt = 0;
        boolean first = true;
        while ((line = buffer.readLine()) != null) {
            line = line.trim();
            // Process line of input Here
            int pos;
            char ch;
            int gatePos = line.indexOf('_');
            int checPos = line.indexOf('C');
            if (checPos>=0) pos=checPos;
                else pos=gatePos;
            if (!first) {
                if (pos>posAnt) ch='\\';
                else if (pos<posAnt) ch='/';
                    else ch = '|';
            }else {
                ch='|';
                first = false;
            }
            posAnt = pos;
            System.out.println(line.substring(0,pos)+ch+line.substring(pos+1));
        }
    }
}

