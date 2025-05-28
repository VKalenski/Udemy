const express = require('express')
const port = 80

const app = express()
app.get('/', (req, res) => {
  res.send('Hello World')
})

app.listen(port, () => {
  console.log(`Example app listening on port ${port}`)
})

//example vulnerable code
mockSocket = new MockSocket()
