FROM node:16

ENV MONGODB_CONNECTION_PROTOCOL mongodb+srv
ENV MONGODB_DB_NAME gha-demo1
ENV MONGODB_CLUSTER_ADDRESS cluster0.k2797r4.mongodb.net
ENV MONGODB_USERNAME vilislavkalenski
ENV MONGODB_PASSWORD x2sIqGeG0mh6wZHu

WORKDIR /app

COPY package*.json .

RUN npm install

COPY . .

CMD ["npm", "start"]