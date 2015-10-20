package programming;

public class PrintNumbers {
	private static int X = 0;

	public static void main(String[] args) {
		if (checkInputData(args)) {
			for (int i = 2; i < X; i++) {
				if (!isNotPrime(i))
					System.out.println(i);
			}
		}
	}

	private static boolean checkInputData(String[] numbers) {
		if (numbers.length > 0) {
			try {
				X = Integer.parseInt(numbers[0]);
				if (X >= 2) {
					return true;
				} else {
					System.out.println("The number should be greather than 2");
					return false;
				}
			} catch (NumberFormatException e) {
				System.out.println("The number is not correctly");
			}
			return true;
		} else {
			System.out.println("X is not specified");
			return false;
		}
	}

	private static boolean isNotPrime(int i) {
		for (int j = 2; j < i; j++) {
			if (i % j == 0) {
				return true;
			}
		}
		return false;
	}
}