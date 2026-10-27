const config = require('../config');
const mysql = require('jano-mysql')(config.mysql);

module.exports = {
    insert: (body) => {
        return mysql.executeObject("INSERT INTO funcionario SET ?", body);
    },
    update: (id, body) => {
        return mysql.executeObject(`UPDATE funcionario SET ? WHERE id = ${id}`, body);
    },
    getById: (id) => {
        return mysql.executeString(`SELECT * from funcionario where id = ${id}`);
    },
    getAll: (filter) => {
        const conditions = [];
        if (filter.nome) {
            conditions.push(`nome = '${filter.nome}'`);
        }
        if (filter.cargo) {
            conditions.push(`cargo like '%${filter.cargo}%'`);
        }

        const where = conditions.length ? ` where ${conditions.join(' and ')}` : '';
        return mysql.executeString(`SELECT * from funcionario${where}`);
    },
    deleteById: (id) => {
        return mysql.executeString(`DELETE from funcionario where id = ${id} `);
    }
}