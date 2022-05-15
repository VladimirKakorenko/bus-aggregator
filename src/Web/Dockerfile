FROM node:16.15.0-alpine
WORKDIR /app

COPY Web/Client/package.json ./
COPY Web/Client/package-lock.json ./
ENV PATH /app/node_modules/.bin:$PATH

RUN npm install

COPY Web/Client ./

CMD ["npm", "start"]



