const PROXY_CONFIG = [
  {
    context: [
      "/PISystem",
    ],
    target: "https://localhost:7137",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
