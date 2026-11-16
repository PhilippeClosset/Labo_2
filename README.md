"# labo2" 
"# Labo_2" 

## Objectif
- mise en application des matières suivantes:
    - HTML/CSS
    - ASP.NET MVC
    - Javascript
    - DB (via Dapper ou EFCore)
    - Git
- suivre l'architecture monolithe en couche (DAL, BLL, App)
- tests unitaires

## Consignes:
La proposition suivante peut être remplacé par votre idée tant qu'elle exploite un maximum les technologies vues précédemment.

Réaliser un site vitrine (le thème est libre).
Les features suivantes doivent être mis en place: 
- Quelques pages (Accueil, About, ...)
- Utilisation d'une Base de donnée
- Connection d'utilisateur 

## Idée : 

Concept:
- Netflim : un faux service de streaming.
    - Les pages : 
        - Page d'acceuil : visible par tous
        - Connection : tout le monde ((DBcontext avec qlq users hardcodé))
        - Videothèque : zone de recherche de film avec filtre 
        - Mon profil : Acces au favoris selectionné dans la vidéothèque 
        - About 
    - Entité/dépendance:
        Image a disposition
