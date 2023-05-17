char* truncateSentence(char* s, int k) {
    char* input[100];
    char* token = strtok(s, " ");
    int i = 0;
    
    while (token != NULL && i < k) {
        input[i++] = token;
        token = strtok(NULL, " ");
    }
    
    int len = 0;
    for (int j = 0; j < i; j++) {
        len += strlen(input[j]);
        if (j != i - 1) {
            len++;  
        }
    }
    
    char* output = malloc(sizeof(char) * (len + 1));
    strcpy(output, "");
    
    for (int j = 0; j < i; j++) {
        strcat(output, input[j]);
        if (j != i - 1) {
            strcat(output, " ");
        }
    }
    
    return output;
}
