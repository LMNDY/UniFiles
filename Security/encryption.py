
def encryptFile(key, filepath):

    # file needs to be read in in chunks, code below dosnt work correctly.
    """
    data = (open(filepath, "rb")).read()
    bytes, chunks = map(ord, data), ""
    encbytes = encryption(key, bytes)
    encdata = "".join(map(chr, encbytes))
    chunks = "%s.enc" % filepath
    (open(chunks, "wb")).write(encdata)
    """
    content = readFile(filepath)
    encryptedContent = encryption(key, content)
    outfileobj = open(filepath, 'w')
    outfileobj.write(encryptedContent)
    outfileobj.close()
    print encryptedContent



    #open decrypt and close file
def decryptFile(key, filepath):
    """
    data = (open(filepath, "rb")).read()
    bytes, chunks = map(ord, data), ""
    decbytes = decryptFile(bytes, key)
    decdata = "".join(map(chr, decbytes))
    chunks = "dec_%s" % ".".join(filepath.split(".")[:-1])
    (open(chunks, "wb")).write(decdata)

    """
    content = readFile(filepath)
    decryptedContent = decryption(key, content)
    outfileobj = open(filepath, 'w')
    outfileobj.write(decryptedContent)
    outfileobj.close()
    print decryptedContent


def readFile(filepath):
    fileobj = open(filepath)
    content = fileobj.read()
    fileobj.close()
    return content


#product cypher.
def encryption(key, message):
    message = vigenere_encrypt(key, message)
    message = railEncrypt(key, message)
    # rail fence cypher to run once for each digit in the key with that number of rails
    # code currently errors
    """
    #for each character of key run rail with that number of rails.
    rail_list = list(str(key))
    for val in rail_list:
        message = railEncrypt(int(val), message)
        """
    message = reverse(message)
    return message

#product cypher
def decryption(key, message):
    message = reverse(message)
    """
    rail_list = list(str(key))
    reverse(rail_list)
    for val in rail_list:
        message = railDecrypt(int(val, message))
        """
    message = railDecrypt(key, message)
    message = vigenere_decrypt(key, message)
    return message


#------------------------------------------------------------------#


def fence(lst, numrails):
    fence = [[None] * len(lst) for n in range(numrails)]
    rails = range(numrails - 1) + range(numrails - 1, 0, -1)
    for n, x in enumerate(lst):
        fence[rails[n % len(rails)]][n] = x

    return [c for rail in fence for c in rail if c is not None]


def railEncrypt(n, text):
    return ''.join(fence(text, n))


def railDecrypt(n, text):
    rng = range(len(text))
    pos = fence(rng, n)
    return ''.join(text[pos.index(n)] for n in rng)

#------------------------------------------------------------------#

def reverse(message):
    translated = ''

    i = len(message) - 1
    while i >= 0:
        translated = translated + message[i]
        i = i - 1

    return translated

#------------------------------------------------------------------#


def vigenere_encrypt(key, message):
    return vtranslate(message, key, "encrypt")


def vigenere_decrypt(key, message):
    return vtranslate(message, key, "decrypt")


def vtranslate(message, key, mode):

    LETTERS = ' !"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~'  # ' ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz1234567890{|}~ '
    translated = []  # stores the encrypted/decrypted message string
    #needs key as string ???
    key = '%s' % key
    keyIndex = 0

    for symbol in message:  # loop through each character in message
        num = LETTERS.find(symbol)
        if num != -1:  # -1 means symbol.upper() was not found in LETTERS
            if mode == 'encrypt':
                num += LETTERS.find(key[keyIndex])  # add if encrypting
            elif mode == 'decrypt':
                num -= LETTERS.find(key[keyIndex])  # subtract if decrypting

            num %= len(LETTERS)  # handle the potential wrap-around

            # add the encrypted/decrypted symbol to the end of translated.
            translated.append(LETTERS[num])

            keyIndex += 1  # move to the next letter in the key
            if keyIndex == len(key):
                keyIndex = 0
        else:
            # The symbol was not in LETTERS, so add it to translated as is.
            translated.append(symbol)

    return ''.join(translated)
