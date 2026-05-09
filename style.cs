/* RESET BÁSICO (faltava isso) */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: Arial, sans-serif;
    background: #0f172a;
    color: white;
    line-height: 1.5;
}

/* HERO */
.hero {
    text-align: center;
    padding: 80px 20px;
}

.hero h1 {
    font-size: 40px;
}

.hero h2 {
    color: #38bdf8;
    margin: 10px 0;
}

.hero p {
    max-width: 500px;
    margin: 0 auto 20px auto; /* corrigido */
}

/* BOTÕES */
.buttons {
    margin-top: 20px;
}

.btn {
    display: inline-block; /* importante */
    background: #38bdf8;
    padding: 10px 20px;
    color: black;
    text-decoration: none;
    margin-right: 10px;
    border-radius: 5px; /* melhoria visual */
    transition: 0.3s;
}

.btn:hover {
    background: #0ea5e9;
}

.btn-outline {
    display: inline-block; /* importante */
    border: 1px solid #38bdf8;
    padding: 10px 20px;
    color: #38bdf8;
    text-decoration: none;
    border-radius: 5px;
    transition: 0.3s;
}

.btn-outline:hover {
    background: #38bdf8;
    color: black;
}

/* SEÇÕES */
section {
    padding: 50px 20px;
    text-align: center;
}

/* GRID PROJETOS */
.grid {
    display: flex;
    gap: 20px;
    justify-content: center;
    flex-wrap: wrap;
}

/* CARD */
.card {
    background: #1e293b;
    padding: 20px;
    border-radius: 10px;
    width: 250px;
    transition: 0.3s;
}

.card:hover {
    transform: translateY(-5px); /* efeito profissional */
}

.card a {
    color: #38bdf8;
    text-decoration: none;
}

/* SKILLS */
.skills {
    margin-top: 20px;
}

.skills span {
    display: inline-block;
    background: #1e293b;
    padding: 10px;
    margin: 5px;
    border-radius: 5px;
}

/* RESPONSIVIDADE (faltava) */
@media (max-width: 600px) {
    .hero h1 {
        font-size: 28px;
    }

    .grid {
        flex-direction: column;
        align-items: center;
    }
}