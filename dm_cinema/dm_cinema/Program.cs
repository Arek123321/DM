// See https://aka.ms/new-console-template for more information
using dm_cinema;

Console.WriteLine("Hello, World!");
Film f = new Film(1982, "Science-Fiction",1, " L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).", "Blade Runner");
f.ToString();
Acteur a=new Acteur(1942,1,"Ford","Harisson");
a.ToString();