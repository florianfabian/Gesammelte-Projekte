from Crypto.Cipher import AES
from Crypto.Random import get_random_bytes

key = get_random_bytes(32)
cipher = AES.new(key, AES.MODE_EAX)
text = "Dies ist ein Test"
ciphertext, tag = cipher.encrypt_and_digest(text.encode())

cipher_decrypt = AES.new(key, AES.MODE_EAX, nonce=cipher.nonce)
plaintext = cipher_decrypt.decrypt_and_verify(ciphertext, tag)
decrypted_text = plaintext.decode()

print("Original text:", text)
print("Decrypted text:", decrypted_text)
