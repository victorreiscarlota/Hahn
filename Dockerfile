FROM mcr.microsoft.com/mssql/server:2022-latest

RUN apt-get update && \
    apt-get install -y locales && \
    sed -i /en_US.UTF-8/s/^# //g /etc/locale.gen && \
    locale-gen

ENV LANG=en_US.UTF-8
ENV LC_ALL=en_US.UTF-8
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
