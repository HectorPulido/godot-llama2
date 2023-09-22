using System;

namespace godotllama2.LLamaClient
{
    public class ChatMessage : LLMMessage
    {
        public string text;
        public float temp = 0.8f;
        public int max_tokens = 50;
        public int top_k = 40;
        public float top_p = 0.4f;
        public float repeat_penalty = 1.18f;
        public int repeat_last_n = 64;
        public int n_batch = 8;
    }
}
