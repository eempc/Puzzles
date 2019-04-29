

public static int[] LeftRotation(int[] arr, int d) {
            //JS Splice method
            //var x = arr.splice(0, d);
            //arr.Concat(x);

            // LINQ take/skip/concat. Can also combine Skip then Take to get the middle elements
            // int[] z = arr.Skip(2).Take(4).ToArray();
            int[] x = arr.Take(d).ToArray();
            int[] y = arr.Skip(d).ToArray();
            return x.Concat(y).ToArray();
        }

        public static int sockMerchant(int[] arr) {
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++) {
                myDict[arr[i]] = 0;
            }

            for (int i = 0; i < arr.Length; i++) {
                int z = arr[i];
                myDict[z]++;
            }

            int count = 0;
            foreach (var x in myDict) {
                count += (x.Value / 2);
            }
            return count;
        }

        public static int sockMerchant2(int[] arr) {
            Array.Sort(arr); // N log N
            int count = 0;
            for (int i = 0; i < arr.Length-1; i++) {
                if (arr[i] == arr[i+1]) {
                    i++;
                    count++;
                }
            }
            return count;
        }

        // Up is better than down, but both would satisfy the fact that you stepped below sea level into a valley
        public static int countingValleys(string str) {
            int altitude = 0;
            int count = 0;
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == 'U') {
                    altitude++;
                    if (altitude == 0) count++;
                } else {
                    altitude--;
                }
            }
            return count;
        }

        // You can always jump one space as per game rules but you can jump two spaces if it is a 0-cloud
        // Refactor would count++ every loop, but if i+2 is 0 then can skip one
        // Length - 1 bit is annoying
        public static int CloudJump(int[] c) {
            int count = 0;
            for (int i = 0; i < c.Length - 1; i++) {
                if (i < c.Length - 2 && c[i+2] == 0) {
                    i++;
                    count++;
                } else {
                    count++;
                }
            }
            return count;
        }

        public static long RepeatedString(string s, long n) {           
            long count = n / s.Length * s.Count(ch => ch == 'a');
            count += (s.Substring(0,(int)(n%s.Length))).Count(ch => ch == 'a');
            return count;
        }

        public static int[] ReverseArray(int[] a) {
            // Example of a[] is 10 elements then O(N) * 1 + 1 = 11 + 10 = 21 operations and 2N = 20 space
            int[] x = new int[a.Length];
            for (int i = 0; i < x.Length; i++) {
                x[i] = a[a.Length - i - 1];
            }
            return x;
        }

        public static int[] ReverseArray2(int[] a) {
            // For 10 elements, this is O(n/2) * 3 = 15 + 5 = 20 operations and 1N + 1 = 11 space
            for (int i = 0; i < a.Length/2; i++) {
                int temp = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = temp;
            }
            return a;
        }

        public static int[] ReverseArray3(int[] a) {
            // IEnumerable method which requires LINQ
            return a.Reverse().ToArray();
        }

        public static int[] ReverseArray4Default(int[] arr) {
            int i = 0;
            int j = arr.Length - 1;
            while (i < j) {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            return arr;
        }

        public static string endXrecurse (string str) {
            if (str.Equals("")) return str;
            else if (str[0] == 'x') {
                return endXrecurse(str.Substring(1)) + "x";
            } else {
                return str[0] + endXrecurse(str.Substring(1));
            }
        }

        public static string allStar(string str) {
            if (str.Length <= 1) return str;
            else return str[0] + "*" + allStar(str.Substring(1));
        }

        public static bool groupSum(int start, int[] nums, int target) {
            if (start >= nums.Length) return (target == 0);
            if (groupSum(start + 1, nums, target - nums[start])) return true;
            if (groupSum(start + 1, nums, target)) return true;
            return false;
        }

        public static bool isPrime(int n) {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++) {
                if (n % i == 0) return false;
            }
            return true;
        }
