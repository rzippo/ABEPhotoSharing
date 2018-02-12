# ABEPhotoSharing

The application here described is a secure photo sharing service which uses KPABE encryption to enforce access to pictures exclusively to allowed users. The application is written in C# for the Windows platform and depends on a KPABE command line implementation developed in C by Yao Zheng [1]. 

KPABE, short for Key-Policy Attribute Based Encryption, is a type of ABE, as the name suggests. ABE is a cryptographic primitive based on public-key encryption, on which the secret key is dependent on attributes assigned to the ciphertext or the key, depending on the type of ABE. Attributes are chosen from a set called the Attribute Universe. One important feature of ABE is that it is collusion-resistant, i.e. an adversary with several keys can decrypt a cyphertext if and only if at least one of them can decrypt it.