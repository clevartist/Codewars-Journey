// MY TRADITIONAL APPROACH
// WHICH CODEWARS DOESN'T ACCEPT FOR SOME REASON

#include <stdio.h>
#include <stdbool.h>
#include <string.h>
#include <ctype.h>

bool alphanumeric(const char* strin) {
    char* allowed_chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    int allowed_ints[] = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};


    if (strchr(strin, '_')) {
        return false;
    }


    for (size_t k = 0; k < strlen(strin); k++) {
        bool is_valid = false; 


        for (size_t o = 0; o < strlen(allowed_chars); o++) {
            if (strin[k] == allowed_chars[o]) {
                is_valid = true;
                break;
            }
        }


        for (size_t p = 0; p < sizeof(allowed_ints) / sizeof(allowed_ints[0]); p++) {
            if (strin[k] == allowed_ints[p] + '0') {
                is_valid = true;
                break;
            }
        }


        if (isspace(strin[k])) {
            return false;
        }

        if (!is_valid) {
            return false;
        }
    }
  
    return true;
}
