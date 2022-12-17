using System.Security.Cryptography;
using System.Text;

namespace AdventOfCode2015.Day04;

public class Puzzle
{
    private string input;

    public Puzzle(string _input)
    {
        input = _input;
    }

    public int PartOne()
    {
        string key = input;
        int answer = 0;
        bool match = false;
        byte[] adventCoinHashed = new byte[0];
        
        while (!match)
        {
            string adventCoin = key + answer;
            byte[] adventCoinBytes = new ASCIIEncoding().GetBytes(adventCoin);
            adventCoinHashed = MD5.HashData(adventCoinBytes);

            match = hasLeadingZeroes(5, adventCoinHashed);
            
            if (!match)
                answer++;
        }

        return answer;
    }

    public int PartTwo()
    {
        string key = input;
        int answer = 0;
        bool match = false;
        byte[] adventCoinHashed = new byte[0];

        while (!match)
        {
            string adventCoin = key + answer;
            byte[] adventCoinBytes = new ASCIIEncoding().GetBytes(adventCoin);
            adventCoinHashed = MD5.HashData(adventCoinBytes);

            match = hasLeadingZeroes(6, adventCoinHashed);

            if (!match)
                answer++;
        }

        return answer;
    }

    public bool hasLeadingZeroes(int zeroes, byte[] hash)
    {
        bool match = false;
        int zeroBytes = zeroes / 2;
        int total = 0;

        for (int i = 0; i < zeroBytes; i++)
            total += hash[i];
        
        if (zeroes % 2 == 1)
        {
            if (hash[zeroBytes] < 16 && total == 0)
                match = true;
        }
        else
        {
            if (total == 0)
                match = true;
        }

        return match;
    }
}
