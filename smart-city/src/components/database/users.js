// src/components/database/users.js
const pool = require('./db');

async function getUsers() {
  try {
    const [rows] = await pool.query('SELECT * FROM users');
    return rows;
  } catch (error) {
    console.error('Error fetching users:', error);
    throw error;
  }
}

async function getUserById(id) {
  try {
    const [rows] = await pool.query('SELECT * FROM users WHERE id = ?', [id]);
    return rows[0];
  } catch (error) {
    console.error('Error fetching user:', error);
    throw error;
  }
}

// Adaugă alte funcții pentru operațiuni CRUD

module.exports = {
  getUsers,
  getUserById
  // exportă celelalte funcții
};