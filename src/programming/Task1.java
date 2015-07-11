package programming;

public class Task1 {

	public static void main(String[] args) {
		int X = 0;
		if (args.length > 0) {
			try {
				X = Integer.parseInt(args[0]);
			} catch (NumberFormatException e) {
				System.out.println("Nieprawid³owa liczba");
			}
		int licznik;
		for (int i = 2; i <= X; ++i) {
            licznik = 0;
            for (int j = 1; j <= i; ++j) {
                if (i % j == 0) {
                    licznik++;
                }
                if (licznik > 2) {
                	licznik=0;
                    break;
                }
            }
            if (licznik == 2)
            	System.out.println(i);
			}
		} else {
			System.out.println("Nie podano parametru X");
		}
	}
}