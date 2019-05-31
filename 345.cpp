class Solution {
public:
    bool isVowels(char c)
    {
    	if(c=='a' || c=='e'|| c=='i'|| c=='o' || c=='u' || c=='A' || c=='E'|| c=='I'|| c=='O' || c=='U' )
    		return true;
    	else
    	    return false;
    }

    string reverseVowels(string s) 
    {
        int sum=-1;
        int vowels[100] = {-1};
        int half=-1;
        char temp='';
        for(int i=0;i<s.length();i++)
        {
    		if(isVowels(s[i]))
    		{
    			++sum;
    			vowels[sum]=i;
    		}
        }
        if(sum%2 > 0)
        {
            half=(sum/2)+1;
        }
        else
        	half=sum/2;
        for(int j=0;j<half;j++)
        {
        	temp=s[vowels[j]];
        	s[vowels[j]]=s[vowels[sum-j]];
        	s[vowels[sum-j]]=temp;
        }
     return s;
     }
};